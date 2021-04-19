using Agricola.Seguridad.Entidades;
using Agricola.Seguridad.Managers;
using AgricolaData.Entities;
using AgricolaData.ViewModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Extensions.Logging;
using Microsoft.Owin.Security;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


using System.Web.Optimization;
using System.Web.Routing;

namespace AgricolaMVC.Controllers
{
    public class SeguridadController : Controller
    {
        private Logger _logger = LogManager.GetLogger("AppDomainLog");

        protected AgricolaSignInManager _signInManager;
        protected AdministradorUsuariosAgricola _userManager;
        protected AgricolaRoleManager _roleManager;
        ApoloData.Context _context = new ApoloData.Context();

        public SeguridadController()
        {
        }
        public SeguridadController(AdministradorUsuariosAgricola userManager, AgricolaSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        public AgricolaSignInManager SignInManager
        {
            get => _signInManager ?? HttpContext.GetOwinContext().Get<AgricolaSignInManager>();
            private set => _signInManager = value;
        }
        public AdministradorUsuariosAgricola UserManager
        {
            get => _userManager ?? HttpContext.GetOwinContext().GetUserManager<AdministradorUsuariosAgricola>();
            private set => _userManager = value;
        }
        public AgricolaRoleManager RoleManager
        {
            get => _roleManager ?? HttpContext.GetOwinContext().GetUserManager<AgricolaRoleManager>();
            private set => _roleManager = value;
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, change to shouldLockout: true
                //var result =
                //    await SignInManager.PasswordSignInAsync(model.usuario, model.clave, model.RememberMe, false);
                var us =  _context.Cat_Usuarios.FirstOrDefault(x => x.Username == model.usuario && x.Clave == model.clave);
                //if(us.IdTaller != null)
                //{
                //    User.Identity.GetTallerId(us.IdTaller);
                //}
                if(us != null)
                {

                    Session["_IdUsuario"] = us.IdUsuario;
                    Session["_UserName"] = us.Username;
                    return RedirectToLocal(returnUrl);
                }
                else
                {
                    ModelState.AddModelError("", "Credenciales no válidas");
                    return View(model);
                }
                //switch (result)
                //{
                //    case SignInStatus.Success:
                //        return RedirectToLocal(returnUrl);
                //    case SignInStatus.LockedOut:
                //        return View("Lockout");
                //    case SignInStatus.RequiresVerification:
                //        return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, model.RememberMe });
                //    case SignInStatus.Failure:
                //    default:
                //        ModelState.AddModelError("", "Credenciales no válidas");
                //        return View(model);
                //}
            }
            catch (Exception e)
            {

                _logger.Error( e.Message);
            }

            return View(model);
        }
        private IAuthenticationManager AuthenticationManager => HttpContext.GetOwinContext().Authentication;

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            return RedirectToAction("Index", "Home", new { area = "" });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session["_IdUsuario"] = null;
            Session["_UserName"] = null;
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Login", "Seguridad");
        }

        public ActionResult ListarUsuarios()
        {
            //ListarEmpleadosViewModel model = new ListarEmpleadosViewModel();

            ListarUsuariosViewModel model = new ListarUsuariosViewModel();
            var lista = _context.Users.Where(c => c.Activo).ToList();

            if (lista != null)
            {
                foreach (var item in lista)
                {
                    Usuarios itemLista = new Usuarios();
                    itemLista.IdUsuario = item.Id;
                    itemLista.Nombres = item.Nombres;
                    itemLista.Apellidos = item.Apellidos;
                    itemLista.Username = item.UserName;
                    itemLista.Apellidos = item.Apellidos;
                    itemLista.Identificacion = item.Identificacion;
     

                    model.Usuarios.Add(itemLista);
                }
            }


            return View(model);
        }

        public ActionResult EditarUsuario(long IdUsuario)
        {
            UsuarioViewModel model = new UsuarioViewModel();

            var empleado = _context.Users.FirstOrDefault(c => c.Activo && c.Id == IdUsuario);

            if (empleado == null)
            {
                return HttpNotFound();
            }
            model.IdUsuario = empleado.Id;
            model.Nombres = empleado.Nombres;
            model.Apellidos = empleado.Apellidos;
            model.UserName = empleado.UserName;
            model.Identificacio = empleado.Identificacion;

            return View(model);
        }

        [HttpPost]
        public ActionResult EditarUsuario(UsuarioViewModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var usuario = _context.Users.Find(modelo.IdUsuario);
                    usuario.Nombres = modelo.Nombres;
                    usuario.Apellidos = modelo.Apellidos;
                    usuario.Identificacion = modelo.Identificacio;
                    usuario.UserName = modelo.UserName;
                    usuario.FechaModificacion = DateTime.Now;
                 
                
                    _context.SaveChanges();
                    return RedirectToAction("ListarUsuarios");
                }
                catch (Exception)
                { 
                    return View(modelo);
                    throw;
                }
            }
            return View(modelo);
        }


        public ActionResult ListarRoles()
        {
            ListarRolesViewModel model = new ListarRolesViewModel();

       
            var roles = _context.Roles.Where(c => c.Activo).ToList();
            if (roles == null)
            {
                return HttpNotFound();
            }
         
            foreach (var item in roles)
            {
               var  itemrol = new AgricolaRoles();
                itemrol.Id = item.Id;
                itemrol.Name = item.Name;
                itemrol.Descripcion = item.Descripcion;
                itemrol.Plural = item.Plural;
                itemrol.Prioridad = item.Prioridad;
                model.Roles.Add(itemrol);
            }
     

            return View(model);
        }


        public ActionResult EditarRoll(long IdRoll)
        {
            RollViewModel model = new RollViewModel();

            var roll = _context.Roles.FirstOrDefault(c => c.Activo && c.Id == IdRoll);

            if (roll == null)
            {
                return HttpNotFound();
            }
            model.IdRoll = roll.Id;
            model.Nombre = roll.Name;
            model.Singular = roll.Plural;
            model.Prioridad = roll.Prioridad;
            model.Descripcion = roll.Descripcion;

            return View(model);
        }
        //public ActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Login(LoginViewModel modelo)
        //{
        //    try
        //    {
        //        var usuario = _context.Usuarios.FirstOrDefault(c => c.Activo 
        //        && c.Username.ToUpper() == modelo.usuario.ToUpper() && c.Clave.ToUpper() == modelo.clave.ToUpper());
        //        if(usuario!= null)
        //        {
        //            Session["User"] = usuario;
        //            Session["IdUsuario"] = usuario.IdUsuario;
        //            return RedirectToAction("Index","Home");

        //            //return RedirectToAction("Index", "Home", "Hacienda", new { area = "" }, new { @class = "item" });
        //        }
        //        else
        //        {
        //            ViewBag.Error = "Usuario o Contraseña invalida";
        //            return View();
        //        }
        //      return  RedirectToAction("");
        //    }
        //    catch (Exception)
        //    {
        //        return RedirectToAction("");
        //        throw;

        //    }

        //}

    }
}
using ApoloCartera.Clases;
using FDLDATA.ViewModel;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApoloCartera.Controllers
{
    public class ArchivoTrackingController : Controller
    {
        private Logger _logger = LogManager.GetLogger("AppDomainLog");
        FDLDATA.Context _context = new FDLDATA.Context();
        private DLArchivoTracking ArchivoExpo = new DLArchivoTracking();

        public ArchivoTrackingController()
        {
            _context = new FDLDATA.Context();

        }

        public ActionResult Registrar()
        {

            string varUsuario = null;
            ListarArchivoTrackingViewModel Model = new ListarArchivoTrackingViewModel();

            if (Session["_IdUsuario"] != null)
            {
                varUsuario = Session["_IdUsuario"].ToString();
            }

            long IdUsuario = 0;
            //string nombreHacienda = "";
            //long IdHacienda = 0;
            if (varUsuario == null)
            {

                return RedirectToAction("Login", "Seguridad", new { area = "" });
            }
            else
            {
                long.TryParse(varUsuario, out IdUsuario);
                var usuario = _context.Cat_Usuarios.FirstOrDefault(c => c.Activo && c.IdUsuario == IdUsuario);
                if (usuario != null)
                {
                    //var hacienda = _context.Haciendas.FirstOrDefault(c => c.Activo && c.Nombre == usuario.NombreHacienda);

                    //IdHacienda = hacienda?.IdHacienda ?? 0;
                    //nombreHacienda = hacienda?.Nombre ?? "";
                }

            }


            return View(Model);
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> Registrar(HttpPostedFileBase upload)
        {
            ListarArchivoTrackingViewModel Model = new ListarArchivoTrackingViewModel();
            if (ModelState.IsValid)
            {

                if (upload != null && upload.ContentLength > 0)
                {

                    var tabla = await   ArchivoExpo.RegistrarAsync(upload);
                    Model.Filas = tabla;


                }
                else
                {
                    ModelState.AddModelError("File", "Please Upload Your file");
                }
            }
            return View(Model);

        }
    }
}
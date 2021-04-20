using Agricola.Seguridad.Entidades;
using FDLDATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDLDATA.ViewModel
{
    class CatalogosViewModels
    {
    }

    public class ListarUsuariosViewModel
    {
        public ListarUsuariosViewModel()
        {
            Usuarios = new List<Usuarios>();
        }
        public List<Usuarios> Usuarios;
    }

    public class ListarRolesViewModel
    {
        public ListarRolesViewModel()
        {
            Roles = new List<AgricolaRoles>();
        }

        public List<AgricolaRoles> Roles;
    }


    public class LoginViewModel
    {
        public string usuario { set; get; }
        public string clave { set; get; }
        public string mensaje { set; get; }
        public bool RememberMe { get; set; }
    }
    public class RollViewModel
    {
        public long? IdRoll { set; get; }
        [Required]
        public string Nombre { set; get; }
        [Required]
        public string Singular { set; get; }
        [Required]
        public string Plural { set; get; }
        [Required]
        public int Prioridad { set; get; }

        public string Descripcion { set; get; }
    }
    public class UsuarioViewModel
    {
        public long? IdUsuario { set; get; }
        [Required]
        public string Nombres { set; get; }
        [Required]
        public string Apellidos { set; get; }
        [Required]
        public string Identificacio { set; get; }
        [Required]
        [Display(Name = "Usuario")]
        public string UserName { set; get; }
    }

    public class ListarArchivoTrackingViewModel
    {
        public ListarArchivoTrackingViewModel()
        {
            Filas = new List<ItemFilaArchivoViewModel>();
        }
        public List<ItemFilaArchivoViewModel> Filas;
    }

    public class ItemFilaArchivoViewModel
    {
        public long? NumFila { set; get; }
        public string Detalle { set; get; }
    }


}


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDLDATA.Entities
{
    public class CrudAuditoria
    {
        public bool Activo { set; get; }
        public string UsuarioCreacion { set; get; }
        public DateTime? FechaCreacion { set; get; }
        public string UsuarioModificacion { set; get; }
        public DateTime? FechaModificacion { set; get; }
        public string UsuarioEliminacion { set; get; }
        public DateTime? FechaEliminacion { set; get; }
    }

    public class Usuarios : CrudAuditoria
    {
        public long IdUsuario { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public string Clave { set; get; }
        public string Identificacion { set; get; }
        public string Username { set; get; }
    }

    //public class Usuarios : CrudAuditoria
    //{
    //    public long IdUsuario { set; get; }
    //    public string Nombres { set; get; }
    //    public string Apellidos { set; get; }
    //    public string Clave { set; get; }
    //    public string Identificacion { set; get; }
    //    public string Username { set; get; }
    //}

    public class Cat_Usuarios : CrudAuditoria
    {
        public long IdUsuario { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public string Clave { set; get; }
        public string Identificacion { set; get; }
        public string Username { set; get; }
    }







 



 

   



}

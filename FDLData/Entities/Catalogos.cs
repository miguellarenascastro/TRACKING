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

    public class NombresFilasTrack : CrudAuditoria
    {
        public long IdNombreFila { set; get; }
        public string NombreArchivo { set; get; }
        public string NombreBase { set; get; }
    }

    public class ArchivoTracking : CrudAuditoria
    {
        public long IdArchivoTracking { set; get; }
        public DateTime FechaCarga { set; get; }
        public string UsuarioCarga { set; get; }
    }

    public class FilasTracking : CrudAuditoria
    {
        public long IdFilaTracking { set; get; }
        public long IdArchivo { set; get; }
        public int YEAR { set; get; }
        public int WEEK { set; get; }
        public string EXPORTED_BY { set; get; }
        public string CONTRACT_TERMS { set; get; }
        public string INCOTERM { set; get; }
        public string CLIENTE_FACTURA_SRI { set; get; }
        public string CLIENTE_GRUPO { set; get; }
        public string CONSIGNEE { set; get; }
        public string NOTIFY { set; get; }
        public string PAIS_DESCARGA { set; get; }
        public string PUERTO_DESCARGA { set; get; }
        public string DESTINO_FINAL { set; get; }
        public string VAPOR { set; get; }
        public string LINEA_NAVIERA { set; get; }
        public string DAE { set; get; }
        public string NO_BL { set; get; }
        public string TIPO_CAJA { set; get; }
        public string TIPO_CARGA_TIPO_CONTENEDOR { set; get; }
        public string MARCA { set; get; }
        public int CNTRS { set; get; }
        public int BOXES { set; get; }
        public decimal TOTAL_PESO_BRUTO { set; get; }
        public decimal TOTAL_PESO_NETO { set; get; }
        public virtual ArchivoTracking ArchivoBase { set; get; }
    }


}

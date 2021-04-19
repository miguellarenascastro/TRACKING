using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricolaData.Models
{
    class BiometricosModel
    {
    }

    public class SP_CONSULTA_MARCACIONES
    {
        public int IdEmpleado { set; get; }
        public string Codigo { set; get; }
        public string Cedula { set; get; }
        public string COLABORADOR { set; get; }
        public string Departamento { set; get; }
        public DateTime Fecha { set; get; }
        public string TIPO { set; get; }
        public int VERIFYCODE { set; get; }
        public string SENSORID { set; get; }
        public int APROBACION { set; get; }
        public int APROBADO { set; get; }
        public string Biometrico { set; get; }
    }


    public class SP_CONSULTA_ALMUERZOS_RESULT
    {
        public int IdEmpleado { set; get; }
        public string Codigo { set; get; }
        public string Cedula { set; get; }
        public string COLABORADOR { set; get; }
        public string Departamento { set; get; }
        public string SENSORID { set; get; }
        public string Biometrico { set; get; }
    }


    public class SP_LISTAR_BIOMETRICOS_RESULT
    {
        public int ID { set; get; }
        public string MachineAlias { set; get; }
        public int MachineNumber { set; get; }

    }



}

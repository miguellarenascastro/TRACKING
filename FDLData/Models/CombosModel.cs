using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricolaData.Models
{
    public class CombosModel
    {
        public class ListarComboIdFDLorOtherInvoiceTo
        {
            public long IdFDLorOtherInvoiceTo { set; get; }
            public string Nombre { set; get; }
        }
        public class ListarComboIdCalfuxInvoiceTo
        {
            public long IdCalfuxInvoiceTo { set; get; }
            public string Nombre { set; get; }
        }

        public class ListarItemComboBancos
        {
            public long IdBanco { set; get; }
            public string Nombre { set; get; }
        }

        public class ListarItemSemana
        {
            public long semana { set; get; }
            public long IDSEMANA { set; get; }
        }


        public class ListarComboIdDischargePort
        {
            public long IdDischargePort { set; get; }
            public string Nombre { set; get; }
        }

        public class ListarComboIdCountryFinalDestination
        {
            public long IdCountryFinalDestination { set; get; }
            public string Nombre { set; get; }
        }
        public class ListarComboIdCountryDiscargePort
        {
            public long IdCountryDischargePort { set; get; }
            public string Nombre { set; get; }
        }

        public class ListarComboIdPaymentBeneficiary
        {
            public long IdPaymentBeneficiary { set; get; }
            public string Nombre { set; get; }
        }

        public class ListarComboIdProductos
        {
            public long Idproducto { set; get; }
            public string Descripcion { set; get; }
        }

        public class ListarComboAnios
        {
            public long Anio { set; get; }
            public string Valor { set; get; }
        }
        public class ListarComboSemana
        {
            public long Anio { set; get; }
            public string Valor { set; get; }
        }


        public class FinalClientCombo
        {
            public long IdFinalClient { get; set; }

            public string Codigo { set; get; }
            public string Nombre { set; get; }
            public string Direccion { set; get; }
            public string NombrePais { set; get; }





            public long? IdCountry { set; get; }

            public bool EsClienteFrutadeli { set; get; }
            public bool EsClienteCalfux { set; get; }

            public decimal? PesoBruto { set; get; }
            public decimal? PesoNeto { set; get; }

            public decimal? PesoNeto208 { set; get; }
            public decimal? PesoBruto208 { set; get; }
            public decimal? PesoNeto22XU { set; get; }
            public decimal? PesoBruto22XU { set; get; }
            public decimal? PesoNetoBB { set; get; }
            public decimal? PesoBrutoBB { set; get; }
            public decimal? PesoNetoBBRed { set; get; }
            public decimal? PesoBrutoBBRed { set; get; }





        }

    }
}

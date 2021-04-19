using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricolaData.ViewModel
{
    public class OrdenesViewModels
    {
        public class ItemOrdenVentaViewModel
        {

            public long? IdOrdenVenta { set; get; }
            [Display(Name = "Fecha")]
            public DateTime FechaOrden { set; get; }
            [Display(Name = "Año")]
            public long ANIO { set; get; }
            [Display(Name = "Mes")]
            public long MES { set; get; }
            [Display(Name = "Semana")]
            public long SEMANA { set; get; }

            [Display(Name = "Exportado Por")]
            public long? IdExportedBy { set; get; }
            [Display(Name = "Exportado Por")]
            public string NombreExportador { set; get; }

            [Display(Name = "Contract Terms")]
            public bool ContractTerms { set; get; }

            [Display(Name = "Sales Terms")]
            public long? IdSalesTerms { set; get; }
            [Display(Name = "Sales Terms")]
            public string NombreSalesTerms { set; get; }

            [Display(Name = "Cia Facturar")]
            public long? IdCiaFacturar { set; get; }
            [Display(Name = "Cia Facturar")]
            public string NombreCiaFacturar { set; get; }

            [Display(Name = "Grupo Cliente")]
            public long? IdCustomerGroup { set; get; }
            [Display(Name = "Grupo Cliente")]
            public string NombreCustomerGroup { set; get; }

            [Display(Name = "Consignatario")]
            public long? IdConsignee { set; get; }
            [Display(Name = "Consignatario")]
            public string NombreConsignee { set; get; }

            [Display(Name = "Notificador")]
            public long? IdNotify { set; get; }
            [Display(Name = "Notificador")]
            public string NombreNotify { set; get; }

            [Display(Name = "FDL or Other Invoice To")]
            public long? IdFDLorOtherInvoiceTo { set; get; } //FDL_OR_OTHER_EXPORTERS_INVOICED_TO
            [Display(Name = "FDL or Other Invoice To")]
            public string NombreFDLorOtherInvoiceTo { set; get; }

            [Display(Name = "Calfux Invoice To")]
            public long? IdCalfuxInvoiceTo { set; get; }
            [Display(Name = "Calfux Invoice To")]
            public string NombreCalfuxInvoiceTo { set; get; }

            [Display(Name = "Pais")]
            public long? IdCountry { set; get; }
            [Display(Name = "Pais")]
            public string NombrePais { set; get; }

            [Display(Name = "Discharge Port")]
            public long? IdDischargePort { set; get; }
            [Display(Name = "Discharge Port")]
            public string NombreDischargePort { set; get; }

            [Display(Name = "Country Final Destination")]
            public long? IdCountryFinalDestination { set; get; }
            [Display(Name = "Country Final Destination")]
            public string NombreFinalDestination { set; get; }

            [Display(Name = "Buque")]
            public long? IdVessel { set; get; }
            [Display(Name = "Buque")]
            public string NombreVessel { set; get; }

            [Display(Name = "Naviera")]
            public long? IdShippingLine { set; get; }
            [Display(Name = "Naviera")]
            public string NombreShippingLine { set; get; }

            [Display(Name = "Marca")]
            public long? IdBrand { set; get; }
            [Display(Name = "Marca")]
            public string NombreBrand { set; get; }

            [Display(Name = "Tipo Caja")]
            public long? IdBoxType { set; get; }
            [Display(Name = "Tipo Caja")]
            public string NombreBoxType { set; get; }

            [Display(Name = "Tipo Envio")]
            public long? IdTypeOfShipment { set; get; }
            [Display(Name = "Tipo Envio")]
            public string NombreTypeOfShipment { set; get; }

            [Display(Name = "Fecha Factura")]
            public DateTime? DateOfInvoice { set; get; }
            [Display(Name = "# Factura SRI")]
            public string NumInvoiceSRI { set; get; }
            [Display(Name = "# Contenedores")]
            public int NumCNTRS { set; get; }
            [Display(Name = "# Cajas")]
            public int NumBOXES { set; get; }
            [Display(Name = "INV 1 FDL OR OTHER EXPORTERS FOB PRICE SRI")]
            public decimal INV_1_FDL_OR_OTHER_EXPORTERS_FOB_PRICE_SRI { set; get; }
            [Display(Name = "INV 1 FDL OR OTHER EXPORTERS FOB AMOUNT PRICE SRI")]
            public decimal INV_1_FDL_OR_OTHER_EXPORTERS_FOB_AMOUNT_PRICE_SRI { set; get; }
            [Display(Name = "FDL OR OTHER EXPORTERS FOB PRICE REAL")]
            public decimal FDL_OR_OTHER_EXPORTERS_FOB_PRICE_REAL { set; get; }
            [Display(Name = "FDL OROTHER EXPORTERS FOB AMOUNT PRICE")]
            public decimal FDL_OR_OTHER_EXPORTERS_FOB_AMOUNT_PRICE { set; get; }
            [Display(Name = "FREIGHT INSURANCE PRICE PER BOX")]
            public decimal FREIGHT_INSURANCE_PRICE_PER_BOX { set; get; }
            [Display(Name = "FREIGHT INSURANCE AMOUNT PRICE PER BOX")]
            public decimal FREIGHT_INSURANCE_AMOUNT_PRICE_PER_BOX { set; get; }
            [Display(Name = "FINAL SALES PRICE")]
            public decimal FINAL_SALES_PRICE { set; get; }

            [Display(Name = "FINAL SALES PRICE AMOUNT")]
            public decimal FINAL_SALES_PRICE_AMOUNT { set; get; }


            [Display(Name = "CREDIT NOTE")]
            public string CREDIT_NOTE { set; get; }

            [Display(Name = "Payment Beneficiary")]
            public long? IdPaymentBeneficiary { set; get; }
            [Display(Name = "Payment Beneficiary")]
            public string NombrePaymentBeneficiary { set; get; }

            [Display(Name = "Payment Terms")]
            public long? IdPaymentTerms { set; get; }
            [Display(Name = "Payment Terms")]
            public string NombrePaymentTerms { set; get; }

            [Display(Name = "Equals")]
            public string EqualsDescription { set; get; }

            [Display(Name = "Type Of Document")]
            public long? IdTypeOfDocument { set; get; }
            [Display(Name = "Type Of Document")]
            public string NombreTypeOfDocument { set; get; }

            [Display(Name = "SERIE")]
            public string SERIE { set; get; }
            [Display(Name = "INVOICE CALFUX")]
            public string INVOICE_CALFUX { set; get; }
            [Display(Name = "INVOICE SRI CALFUX FRUIT SALE")]
            public string INVOICE_SRI_CALFUX_FRUIT_SALE { set; get; }
            [Display(Name = "INVOICE SRI CALFUX FREIGHT INSURANCE")]
            public string INVOICE_SRI_CALFUX_FREIGHT_INSURANCE { set; get; }
            [Display(Name = "Release Date")]
            public DateTime? RELEASE_DATE { set; get; }
            [Display(Name = "Fecha Solicitud de Liberacion")]
            public DateTime? FECHA_SOLICITUD_DE_LIBERACION { set; get; }
            [Display(Name = "# DAE")]
            public string Num_DAE { set; get; }
            [Display(Name = "# BL")]
            public string Num_BL { set; get; }

            [Display(Name = "Our Ref")]
            public string OurRef { set; get; }
            [Display(Name = "Release Date")]
            public DateTime? ReleaseDate { set; get; }
            [Display(Name = "Release")]
            public bool? Release { set; get; }

            [Display(Name = "Producto")]
            public long? Idproducto { set; get; }

            [Display(Name = "Producto")]
            public string DescripcionProducto { set; get; }

            [Display(Name = "Banco")]
            public long? IdBanco { set; get; }

            //public long IdPedido { set; get; }
            public bool EsOrdenPadre { set; get; }
            public long? IdOriginalOrdenVenta { set; get; }
            public long Orden { set; get; }
        }



    }
    public class CabOrdenVentaViewModel
    {


        public CabOrdenVentaViewModel()
        {
            Detalle = new List<ItemDetOrdenVentaViewModel>();
        }



        public long? IdOrdenVenta { set; get; }
        [Display(Name = "Date")]
        public DateTime FechaOrden { set; get; }
        [Display(Name = "Year")]
        public long ANIO { set; get; }
        [Display(Name = "Month")]
        public long MES { set; get; }
        [Display(Name = "Week")]
        public long SEMANA { set; get; }

        [Display(Name = "Exported By")]
        public long? IdExportedBy { set; get; }
        [Display(Name = "Exported By")]
        public string NombreExportador { set; get; }

        [Display(Name = "Contract Terms")]
        public bool ContractTerms { set; get; }

        [Display(Name = "Sales Terms")]
        public long? IdSalesTerms { set; get; }
        [Display(Name = "Sales Terms")]
        public string NombreSalesTerms { set; get; }

        [Display(Name = "Company to Bill")]
        public long? IdCiaFacturar { set; get; }
        [Display(Name = "Company to Bill")]
        public string NombreCiaFacturar { set; get; }

        [Display(Name = "Customer Group")]
        public long? IdCustomerGroup { set; get; }
        [Display(Name = "Customer Group")]
        public string NombreCustomerGroup { set; get; }

        [Display(Name = "Consignee")]
        public long? IdConsignee { set; get; }
        [Display(Name = "Consignee")]
        public string NombreConsignee { set; get; }

        [Display(Name = "Notify")]
        public long? IdNotify { set; get; }
        [Display(Name = "Notify")]
        public string NombreNotify { set; get; }

        [Display(Name = "Final Client")]
        public long? IdFDLorOtherInvoiceTo { set; get; } //FDL_OR_OTHER_EXPORTERS_INVOICED_TO
        [Display(Name = "FDL or Other Invoice To")]
        public string NombreFDLorOtherInvoiceTo { set; get; }

        [Display(Name = "Cod Final Client")]
        public string CodFinalClient { set; get; }
        [Display(Name = "Address Client")]
        public string DireccionFinalClient { set; get; }
        [Display(Name = "Country Client")]
        public string NombrePaisFinalClient { set; get; }


        [Display(Name = "Calfux Invoice To")]
        public long? IdCalfuxInvoiceTo { set; get; }
        [Display(Name = "Calfux Invoice To")]
        public string NombreCalfuxInvoiceTo { set; get; }

        [Display(Name = "Country")]
        public long? IdCountry { set; get; }
        [Display(Name = "Country")]
        public string NombrePais { set; get; }

        [Display(Name = "Discharge Port")]
        public long? IdDischargePort { set; get; }
        [Display(Name = "Discharge Port")]
        public string NombreDischargePort { set; get; }

        [Display(Name = "Country Final Destination")]
        public long? IdCountryFinalDestination { set; get; }

        [Display(Name = "Country Discharge")]
        public long? IdCountryDiscargePort { set; get; } 

        [Display(Name = "Country Final Destination")]
        public string NombreFinalDestination { set; get; }

        [Display(Name = "Vessel")]
        public long? IdVessel { set; get; }
        [Display(Name = "Vessel")]
        public string NombreVessel { set; get; }

        [Display(Name = "Shipping Line")]
        public long? IdShippingLine { set; get; }
        [Display(Name = "Shipping Line")]
        public string NombreShippingLine { set; get; }

        [Display(Name = "Brand")]
        public long? IdBrand { set; get; }
        [Display(Name = "Brand")]
        public string NombreBrand { set; get; }

        [Display(Name = "Box Type")]
        public long? IdBoxType { set; get; }
        [Display(Name = "Box Type")]
        public string NombreBoxType { set; get; }

        [Display(Name = "Type Of Shipment")]
        public long? IdTypeOfShipment { set; get; }
        [Display(Name = "Type Of Shipment")]
        public string NombreTypeOfShipment { set; get; }

        [Display(Name = "Date Of Invoicea")]
        public DateTime? DateOfInvoice { set; get; }
        [Display(Name = "# Invoice SRI")]
        public string NumInvoiceSRI { set; get; }
        [Display(Name = "# CNTRS")]
        public int NumCNTRS { set; get; }
        [Display(Name = "# BOXES")]
        public int NumBOXES { set; get; }
        [Display(Name = "INV 1 FDL OR OTHER EXPORTERS FOB PRICE SRI")]
        public decimal INV_1_FDL_OR_OTHER_EXPORTERS_FOB_PRICE_SRI { set; get; }
        [Display(Name = "INV 1 FDL OR OTHER EXPORTERS FOB AMOUNT PRICE SRI")]
        public decimal INV_1_FDL_OR_OTHER_EXPORTERS_FOB_AMOUNT_PRICE_SRI { set; get; }
        [Display(Name = "FDL OR OTHER EXPORTERS FOB PRICE REAL")]
        public decimal FDL_OR_OTHER_EXPORTERS_FOB_PRICE_REAL { set; get; }
        [Display(Name = "FDL OROTHER EXPORTERS FOB AMOUNT PRICE")]
        public decimal FDL_OR_OTHER_EXPORTERS_FOB_AMOUNT_PRICE { set; get; }
        [Display(Name = "FREIGHT INSURANCE PRICE PER BOX")]
        public decimal FREIGHT_INSURANCE_PRICE_PER_BOX { set; get; }
        [Display(Name = "FREIGHT INSURANCE AMOUNT PRICE PER BOX")]
        public decimal FREIGHT_INSURANCE_AMOUNT_PRICE_PER_BOX { set; get; }
        [Display(Name = "FINAL SALES PRICE")]
        public decimal FINAL_SALES_PRICE { set; get; }

        [Display(Name = "FINAL SALES PRICE AMOUNT")]
        public decimal FINAL_SALES_PRICE_AMOUNT { set; get; }

        [Display(Name = "CREDIT NOTE")]
        public string CREDIT_NOTE { set; get; }

        [Display(Name = "Payment Beneficiary")]
        public long? IdPaymentBeneficiary { set; get; }
        [Display(Name = "Payment Beneficiary")]
        public string NombrePaymentBeneficiary { set; get; }

        [Display(Name = "Payment Terms")]
        public long? IdPaymentTerms { set; get; }
        [Display(Name = "Payment Terms")]
        public string NombrePaymentTerms { set; get; }

        [Display(Name = "Equals")]
        public string EqualsDescription { set; get; }

        [Display(Name = "Type Of Document")]
        public long? IdTypeOfDocument { set; get; }
        [Display(Name = "Type Of Document")]
        public string NombreTypeOfDocument { set; get; }

        [Display(Name = "SERIE")]
        public string SERIE { set; get; }
        [Display(Name = "INVOICE CALFUX")]
        public string INVOICE_CALFUX { set; get; }
        [Display(Name = "INVOICE SRI CALFUX FRUIT SALE")]
        public string INVOICE_SRI_CALFUX_FRUIT_SALE { set; get; }
        [Display(Name = "INVOICE SRI CALFUX FREIGHT INSURANCE")]
        public string INVOICE_SRI_CALFUX_FREIGHT_INSURANCE { set; get; }
        [Display(Name = "Release Date")]
        public DateTime? RELEASE_DATE { set; get; }
        [Display(Name = "Fecha Solicitud de Liberacion")]
        public DateTime? FECHA_SOLICITUD_DE_LIBERACION { set; get; }
        [Display(Name = "# DAE")]
        public string Num_DAE { set; get; }
        [Display(Name = "# BL")]
        public string Num_BL { set; get; }

        [Display(Name = "Our Ref")]
        public string OurRef { set; get; }
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { set; get; }
        [Display(Name = "Release")]
        public bool? Release { set; get; }

        [Display(Name = "Producto")]
        public long? Idproducto { set; get; }

        [Display(Name = "Producto")]
        public string DescripcionProducto { set; get; }

        [Display(Name = "Banco")]
        public long? IdBanco { set; get; }

        [Display(Name = "PLAN")]
        public String Cplan { set; get; }
        public bool cerrada { set; get; }
        public bool? Modificada { set; get; }
        public string ColorFondo { set; get; }


        public bool EsOrdenPadre { set; get; }
        public long? IdOriginalOrdenVenta { set; get; }
        public long Orden { set; get; }

        public bool? esOrdenCreada { set; get; }

        public List<ItemDetOrdenVentaViewModel> Detalle;

    }



    public class ItemDetOrdenVentaViewModel
    {

        public long? IdOrdenVenta { set; get; }

        [Display(Name = "Marca")]
        public long? IdBrand { set; get; }
        [Display(Name = "Marca")]
        public string NombreBrand { set; get; }

        [Display(Name = "Tipo Caja")]
        public long? IdBoxType { set; get; }
        [Display(Name = "Tipo Caja")]
        public string NombreBoxType { set; get; }

        [Display(Name = "Tipo Envio")]
        public long? IdTypeOfShipment { set; get; }
        [Display(Name = "Tipo Envio")]
        public string NombreTypeOfShipment { set; get; }

        [Display(Name = "# Contenedores")]
        public int NumCNTRS { set; get; }
        [Display(Name = "# Cajas")]
        public int NumBOXES { set; get; }
        [Display(Name = "INV 1 FDL OR OTHER EXPORTERS FOB PRICE SRI")]
        public decimal INV_1_FDL_OR_OTHER_EXPORTERS_FOB_PRICE_SRI { set; get; }
        [Display(Name = "INV 1 FDL OR OTHER EXPORTERS FOB AMOUNT PRICE SRI")]
        public decimal INV_1_FDL_OR_OTHER_EXPORTERS_FOB_AMOUNT_PRICE_SRI { set; get; }
        [Display(Name = "FDL OR OTHER EXPORTERS FOB PRICE REAL")]
        public decimal FDL_OR_OTHER_EXPORTERS_FOB_PRICE_REAL { set; get; }
        [Display(Name = "FDL OROTHER EXPORTERS FOB AMOUNT PRICE")]
        public decimal FDL_OR_OTHER_EXPORTERS_FOB_AMOUNT_PRICE { set; get; }
        [Display(Name = "FREIGHT INSURANCE PRICE PER BOX")]
        public decimal FREIGHT_INSURANCE_PRICE_PER_BOX { set; get; }
        [Display(Name = "FREIGHT INSURANCE AMOUNT PRICE PER BOX")]
        public decimal FREIGHT_INSURANCE_AMOUNT_PRICE_PER_BOX { set; get; }
        [Display(Name = "FINAL SALES PRICE")]
        public decimal FINAL_SALES_PRICE { set; get; }

        [Display(Name = "FINAL SALES PRICE AMOUNT")]
        public decimal FINAL_SALES_PRICE_AMOUNT { set; get; }


        [Display(Name = "BL")]
        public string NUM_BL { set; get; }

        [Display(Name = "DAE")]
        public string NUM_DAE { set; get; }


        [Display(Name = "COUNTRY DISCHARGE PORT")]
        public long? IdCountryDischargePort { set; get; }
        //[Display(Name = "CREDIT NOTE")]
        //public string CREDIT_NOTE { set; get; }
        public bool ContractTerms { set; get; }

        public string cplan { set; get; }
        public bool EsOrdenPadre { set; get; }
        public long? IdOriginalOrdenVenta { set; get; }
        public long Orden { set; get; }
    }



    public class CabCombineOrdenVentaViewModel
    {

        public CabCombineOrdenVentaViewModel()
        {
            Detalle = new List<ItemCombineDetOrdenVentaViewModel>();

            Combinar = new  List<ItemCombinarViewModel>() ;
    }

        [Display(Name = "Fecha")]
        public DateTime FechaOrden { set; get; }
        [Display(Name = "Año")]
        public long ANIO { set; get; }
        [Display(Name = "Mes")]
        public long MES { set; get; }
        [Display(Name = "Semana")]
        public long SEMANA { set; get; }

        [Display(Name = "Exportado Por")]
        public long? IdExportedBy { set; get; }
        [Display(Name = "Exportado Por")]
        public string NombreExportador { set; get; }

        [Display(Name = "Sales Terms")]
        public long? IdSalesTerms { set; get; }

        [Display(Name = "Sales Terms")]
        public string NombreSalesTerms { set; get; }

        [Display(Name = "Cia Facturar")]
        public long? IdCiaFacturar { set; get; }

        [Display(Name = "Cia Facturar")]
        public string NombreCiaFacturar { set; get; }

        [Display(Name = "Grupo Cliente")]
        public long? IdCustomerGroup { set; get; }
        [Display(Name = "Grupo Cliente")]
        public string NombreCustomerGroup { set; get; }

        [Display(Name = "Consignatario")]
        public long? IdConsignee { set; get; }
        [Display(Name = "Consignatario")]
        public string NombreConsignee { set; get; }

        [Display(Name = "Notificador")]
        public long? IdNotify { set; get; }
        [Display(Name = "Notificador")]
        public string NombreNotify { set; get; }

        [Display(Name = "Final Client")]
        public long? IdFDLorOtherInvoiceTo { set; get; } //FDL_OR_OTHER_EXPORTERS_INVOICED_TO
        [Display(Name = "FDL or Other Invoice To")]
        public string NombreFDLorOtherInvoiceTo { set; get; }

        [Display(Name = "Pais")]
        public long? IdCountry { set; get; }
        [Display(Name = "Pais")]
        public string NombrePais { set; get; }

        [Display(Name = "Discharge Port")]
        public long? IdDischargePort { set; get; }
        [Display(Name = "Discharge Port")]
        public string NombreDischargePort { set; get; }

        [Display(Name = "Country Final Destination")]
        public long? IdCountryFinalDestination { set; get; }

        [Display(Name = "Country Discharge Port")]
        public long? IdCountryDiscargePort { set; get; }

        [Display(Name = "Country Discharge Port")]
        public string NombreCountryDiscargePort { set; get; }

        [Display(Name = "Country Final Destination")]
        public string NombreFinalDestination { set; get; }

        [Display(Name = "Buque")]
        public long? IdVessel { set; get; }
        [Display(Name = "Buque")]
        public string NombreVessel { set; get; }

        [Display(Name = "Naviera")]
        public long? IdShippingLine { set; get; }
        [Display(Name = "Naviera")]
        public string NombreShippingLine { set; get; }

        [Display(Name = "Fecha Factura")]
        public DateTime? DateOfInvoice { set; get; }
        [Display(Name = "# Factura SRI")]
        public string NumInvoiceSRI { set; get; }

        [Display(Name = "Payment Beneficiary")]
        public long? IdPaymentBeneficiary { set; get; }
        [Display(Name = "Payment Beneficiary")]
        public string NombrePaymentBeneficiary { set; get; }

        [Display(Name = "Payment Terms")]
        public long? IdPaymentTerms { set; get; }
        [Display(Name = "Payment Terms")]
        public string NombrePaymentTerms { set; get; }

        [Display(Name = "Type Of Document")]
        public long? IdTypeOfDocument { set; get; }
        [Display(Name = "Type Of Document")]
        public string NombreTypeOfDocument { set; get; }

        [Display(Name = "INVOICE CALFUX")]
        public string INVOICE_CALFUX { set; get; }
        [Display(Name = "INVOICE SRI CALFUX FRUIT SALE")]
        public string INVOICE_SRI_CALFUX_FRUIT_SALE { set; get; }
        [Display(Name = "INVOICE SRI CALFUX FREIGHT INSURANCE")]
        public string INVOICE_SRI_CALFUX_FREIGHT_INSURANCE { set; get; }
        [Display(Name = "Release Date")]
        public DateTime? RELEASE_DATE { set; get; }
        [Display(Name = "Fecha Solicitud de Liberacion")]
        public DateTime? FECHA_SOLICITUD_DE_LIBERACION { set; get; }
        [Display(Name = "# DAE")]
        public string Num_DAE { set; get; }
        [Display(Name = "# BL")]
        public string Num_BL { set; get; }


        [Display(Name = "Banco")]
        public long? IdBanco { set; get; }

        [Display(Name = "Bank")]
        public string NombreBanco { set; get; }

        [Display(Name = "PLAN")]
        public String Cplan { set; get; }
        public bool cerrada { set; get; }
        public bool? Modificada { set; get; }
        public string ColorFondo { set; get; }


        public bool EsOrdenPadre { set; get; }
        public long? IdOriginalOrdenVenta { set; get; }
        public long Orden { set; get; }

        public bool? esOrdenCreada { set; get; }

        public String Cplan1 { set; get; }
        public String Cplan2 { set; get; }


        public List<ItemCombineDetOrdenVentaViewModel> Detalle;

        public List<ItemCombinarViewModel> Combinar;

    }

    public class ItemCombinarViewModel
    {

        public string cplan { set; get; }

        public long? IdOrdenVenta { set; get; }
        [Display(Name = "Marca")]
        public long? IdBrand { set; get; }
        [Display(Name = "Marca")]
        public string NombreBrand { set; get; }

        [Display(Name = "Tipo Caja")]
        public long? IdBoxType { set; get; }
        [Display(Name = "Tipo Caja")]
        public string NombreBoxType { set; get; }

        [Display(Name = "Tipo Envio")]
        public long? IdTypeOfShipment { set; get; }
        [Display(Name = "Tipo Envio")]
        public string NombreTypeOfShipment { set; get; }

        [Display(Name = "# Contenedores")]
        public int NumCNTRS { set; get; }
        [Display(Name = "# Cajas")]
        public int NumBOXES { set; get; }

        [Display(Name = "FINAL SALES PRICE")]
        public decimal FINAL_SALES_PRICE { set; get; }

        [Display(Name = "FINAL SALES PRICE AMOUNT")]
        public decimal FINAL_SALES_PRICE_AMOUNT { set; get; }

        public bool ContractTerms { set; get; }

        public bool? Combinar { set; get; }

    }


    public class ItemCombineDetOrdenVentaViewModel
    {

        public long? IdOrdenVenta { set; get; }

        [Display(Name = "Marca")]
        public long? IdBrand { set; get; }
        [Display(Name = "Marca")]
        public string NombreBrand { set; get; }

        [Display(Name = "Tipo Caja")]
        public long? IdBoxType { set; get; }
        [Display(Name = "Tipo Caja")]
        public string NombreBoxType { set; get; }

        [Display(Name = "Tipo Envio")]
        public long? IdTypeOfShipment { set; get; }
        [Display(Name = "Tipo Envio")]
        public string NombreTypeOfShipment { set; get; }

        [Display(Name = "# Contenedores")]
        public int NumCNTRS { set; get; }
        [Display(Name = "# Cajas")]
        public int NumBOXES { set; get; }

        [Display(Name = "FINAL SALES PRICE")]
        public decimal FINAL_SALES_PRICE { set; get; }

        [Display(Name = "FINAL SALES PRICE AMOUNT")]
        public decimal FINAL_SALES_PRICE_AMOUNT { set; get; }

        public bool ContractTerms { set; get; }
        public bool? EsCombinada { set; get; }



        public string cplan { set; get; }
        public bool EsOrdenPadre { set; get; }
        public long? IdOriginalOrdenVenta { set; get; }
        public long Orden { set; get; }
    }


}

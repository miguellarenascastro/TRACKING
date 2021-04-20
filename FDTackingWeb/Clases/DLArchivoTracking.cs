using ExcelDataReader;
using FDLDATA.ViewModel;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using FDLDATA.Entities;

namespace ApoloCartera.Clases
{
    public class DLArchivoTracking
    {
        private Logger _logger = LogManager.GetLogger("AppDomainLog");
        FDLDATA.Context _context = new FDLDATA.Context();

        public DLArchivoTracking()
        {
            _context = new FDLDATA.Context();
        }

        public async Task<List<ItemFilaArchivoViewModel>> RegistrarAsync(HttpPostedFileBase upload)
        {

            List<ItemFilaArchivoViewModel> Lista = new List<ItemFilaArchivoViewModel>();

            if (upload != null && upload.ContentLength > 0)
            {
                try
                {
                    // ExcelDataReader works with the binary Excel file, so it needs a FileStream
                    // to get started. This is how we avoid dependencies on ACE or Interop:
                    Stream stream = upload.InputStream;

                    // We return the interface, so that
                    IExcelDataReader reader = null;

                    if (upload.FileName.EndsWith(".xls"))
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    else if (upload.FileName.EndsWith(".xlsx"))
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    else
                    {
                        //ModelState.AddModelError("File", "This file format is not supported");
                        return Lista; ;
                    }

                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    if (result != null && result.Tables[0].Rows.Count > 0)
                    {

                        using (DbContextTransaction transaction = _context.Database.BeginTransaction())
                        {
                            try
                            {
                                ArchivoTracking cabecera = new ArchivoTracking();
                                 
                                cabecera.FechaCarga = DateTime.Now;
                                cabecera.UsuarioCarga = "SYSTEM";
                                cabecera.Activo = true;
                                cabecera.FechaCreacion = DateTime.Now;
                                cabecera.UsuarioCreacion = "SYSTEM";

                                _context.ArchivoTrackings.Add(cabecera);
                                _context.SaveChanges();

                                int NumeroFila = 2;
                                foreach (var item in result.Tables[0].Rows)
                                {

                                    if ((((System.Data.DataRow)item).ItemArray[0] != null) && (((System.Data.DataRow)item).ItemArray[0].ToString() != ""))
                                    {


                                        FilasTracking fila = new FilasTracking();
                                        

                                        ItemFilaArchivoViewModel itemFila = new ItemFilaArchivoViewModel();

                                        itemFila.NumFila = NumeroFila;

                                        //int cajasP = 0;
                                        //int cjasOrg = 0;
                                        //int NUM_CTNRSPLAN = 0;
                                        //int.TryParse(((System.Data.DataRow)item).ItemArray[2].ToString(), out cajasP);
                                        //int.TryParse(((System.Data.DataRow)item).ItemArray[3].ToString(), out cjasOrg);
                                        //int.TryParse(((System.Data.DataRow)item).ItemArray[4].ToString(), out NUM_CTNRSPLAN);

                                        fila.IdArchivo = cabecera.IdArchivoTracking;
                                        fila.YEAR = int.Parse(((System.Data.DataRow)item).ItemArray[0].ToString());
                                        fila.WEEK = int.Parse( ((System.Data.DataRow)item).ItemArray[1].ToString());
                                        fila.EXPORTED_BY = ((System.Data.DataRow)item).ItemArray[2].ToString();
                                        fila.CONTRACT_TERMS  = ((System.Data.DataRow)item).ItemArray[3].ToString();
                                        fila.INCOTERM = ((System.Data.DataRow)item).ItemArray[4].ToString();
                                        fila.CLIENTE_FACTURA_SRI = ((System.Data.DataRow)item).ItemArray[5].ToString();
                                        fila.CLIENTE_GRUPO = ((System.Data.DataRow)item).ItemArray[6].ToString();
                                        fila.CONSIGNEE =  ((System.Data.DataRow)item).ItemArray[7].ToString();
                                        fila.NOTIFY = ((System.Data.DataRow)item).ItemArray[8].ToString();
                                        fila.PAIS_DESCARGA = ((System.Data.DataRow)item).ItemArray[9].ToString();
                                        fila.PUERTO_DESCARGA = ((System.Data.DataRow)item).ItemArray[10].ToString();
                                        fila.DESTINO_FINAL = ((System.Data.DataRow)item).ItemArray[11].ToString();
                                        fila.VAPOR = ((System.Data.DataRow)item).ItemArray[12].ToString();
                                        fila.LINEA_NAVIERA = ((System.Data.DataRow)item).ItemArray[14].ToString();
                                        fila.DAE = ((System.Data.DataRow)item).ItemArray[15].ToString();
                                        fila.NO_BL = ((System.Data.DataRow)item).ItemArray[16].ToString();
                                        fila.TIPO_CAJA = ((System.Data.DataRow)item).ItemArray[17].ToString();
                                        fila.TIPO_CARGA = ((System.Data.DataRow)item).ItemArray[18].ToString();
                                        fila.TIPO_CONTENEDOR = ((System.Data.DataRow)item).ItemArray[19].ToString();
                                        fila.MARCA = ((System.Data.DataRow)item).ItemArray[20].ToString();
                                        fila.CNTRS = int.Parse(((System.Data.DataRow)item).ItemArray[21].ToString());
                                        fila.BOXES = int.Parse(((System.Data.DataRow)item).ItemArray[22].ToString());
                                        fila.TOTAL_PESO_BRUTO = decimal.Parse(((System.Data.DataRow)item).ItemArray[23].ToString());
                                        fila.TOTAL_PESO_NETO = decimal.Parse(((System.Data.DataRow)item).ItemArray[24].ToString());


                                        //if (((System.Data.DataRow)item).ItemArray[26] != null && (((System.Data.DataRow)item).ItemArray[26].ToString().Trim() != ""))
                                        //{
                                        //    DateTime FECHAHORACUTOFF;
                                        //    DateTime.TryParse(((System.Data.DataRow)item).ItemArray[26].ToString(), out FECHAHORACUTOFF);
                                        //    fila.FECHAHORACUTOFF = FECHAHORACUTOFF;
                                        //}
                                        _context.FilasTrackings.Add(fila);
                                        
                                        _context.SaveChanges();

                                        var op = false;
                                        op = await RegistrarFila(fila);

                                        if (op == true)
                                        {
                                            itemFila.Detalle = "Registrada Correctamente";
                                            Lista.Add(itemFila);
                                            NumeroFila = NumeroFila + 1;
                                        }
                                        else
                                        {
                                            itemFila.Detalle = "Error al registrar Fila";
                                            Lista.Add(itemFila);
                                            NumeroFila = NumeroFila + 1;
                                        }


                                    }
                                }
                                transaction.Commit();
                                return Lista;

                            }
                            catch (Exception e)
                            {
                                transaction.Rollback();
                                throw;
                                // return false;
                            }
                        }
                    }
                }
                catch (Exception e)
                {

                    throw;
                }
            }
            return Lista;
        }

        public async Task<bool> RegistrarFila( FilasTracking  fila)
        {
            try
            {
                //var CustomerGroup = RegistrarCustomerGroup(fila.CLIENTEGRUPO, fila.IdClienteGrupo);
                //var Consignee = RegistrarConsignee(fila.CONSIGNEE, fila.IdConsignatario, CustomerGroup.IdCustomerGroup);
                //var Notify = RegistrarNotificador(fila.Notificar, fila.IdNotify, Consignee.IdConsignee);
                //var Naviera = RegistraNaviera(fila.NAVIERA);
                //var Cliente = RegistraCliente(fila.CLIENTE, fila.IdCliente);
                //var PaisDescarga = RegistrarPaisDescarga(fila.PAISDESCARGA);
                //var PuertoDescarga = RegistrarPuertoDescarga(fila.PUERTODESCARGA, PaisDescarga.IdCountry);
                //var DestinoFinal = RegistrarPaisDescarga(fila.DESTINOFINAL);
                //var Vessel = RegistrarVapor(fila.VAPOR);
                //var PaisEmbarque = RegistrarPaisDescarga("ECUADOR");
                //var PuertoEmbarque = RegistrarPuertoDescarga(fila.PUERTODESCARGA, PaisEmbarque.IdCountry);
                //var TipoCarga = RegistrarTipoCarga(fila.TIPOCARGA);
                //var TerminosVenta = RegistrarTerminosVenta(fila.INCOTERM);
                //var Marca = RegistrarMarca(fila.MARCA);
                //var TipoCaja = RegistrarTipoCaja(fila.TIPOCAJA_1);
                //var Exportador = RegistrarExportador("FDL");
                //var CiaFacturar = RegistrarCIAFacturar("FRUTADELI S.A.");

                int semana = 0;
                int anio = 0;
                int mes = 0;

                //string sanio = fila.SEMANADECLARADA.Substring(0, 4);
                //string ssemana = fila.SEMANADECLARADA.Substring(4, 2);
                //int.TryParse(sanio, out anio);
                //int.TryParse(fila.SEMANADECLARADA, out mes);
                //int.TryParse(ssemana, out semana);

                bool op = false;

                if (fila.DAE != "" && fila.NO_BL != "")
                {

                    op = await RegistrarOrdenVenta(anio, mes, semana, CustomerGroup, Consignee, Notify, Naviera, Cliente, PaisDescarga, PuertoDescarga,
                       DestinoFinal, Vessel, PaisEmbarque, PuertoEmbarque, TerminosVenta, TipoCarga, Marca, TipoCaja, Exportador, CiaFacturar,
                       fila);
                }


                return op;

            }
            catch (Exception e)
            {

                throw;
            }
            return false;
        }


        public async Task<bool> RegistrarOrdenVenta(int ANIO, int MES, int SEMANA, CustomerGroup Customer, Consignee consignee, Notify Notify, ShippingLine Naviera, FinalClient Cliente, Country PaisDescarga, Port PuertoDescarga, Country PaisDestino, Vessel Nave,
    Country PaisEmbarque, Port PuertoEmbarque, SalesTerms TerminosVenta, TypeOfShipment TipoCarga, Brand Marca, BoxType TipoCaja, ExportedBy Exportador, Beneficiarios CiaFacturar,
    ArchivoBaseRow fila)
        {

            try
            {

                var op = _context.OrdenVentas.FirstOrDefault(c => c.Activo && c.cplan == fila.CPLAN && c.NumInvoiceSRI == fila.NFacturaSRI);

                if (op != null)
                {
                    return false;
                }

                OrdenVenta NuevoRegistro = new OrdenVenta();

                var paisEC = _context.Countries.FirstOrDefault(c => c.Activo && c.Nombre.ToUpper() == "ECUADOR");
                var tipoDoc = _context.TypeOfDocuments.FirstOrDefault(c => c.Activo && c.Nombre.ToUpper() == "COMMERCIAL INVOICE");
                NuevoRegistro.FechaOrden = DateTime.Now;
                NuevoRegistro.ANIO = ANIO;
                NuevoRegistro.MES = MES;
                //NuevoRegistro.SEMANA = WeeksInYear(NuevoRegistro.FechaOrden);
                NuevoRegistro.SEMANA = SEMANA;


                NuevoRegistro.IdSalesTerms = TerminosVenta.IdSalesTerms;
                if (fila.TIPOCLIENTE == "CONTRATO")
                {
                    NuevoRegistro.ContractTerms = true;
                }
                else
                {
                    NuevoRegistro.ContractTerms = false;
                }
                NuevoRegistro.IdFDLorOtherInvoiceTo = Cliente.IdFinalClient;

                NuevoRegistro.IdCustomerGroup = Customer.IdCustomerGroup;
                NuevoRegistro.IdConsignee = consignee.IdConsignee;
                NuevoRegistro.IdNotify = Notify.IdNotify;

                NuevoRegistro.IdExportedBy = Exportador.IdExportedBy;
                NuevoRegistro.IdCiaFacturar = CiaFacturar.IdBeneficiario;

                NuevoRegistro.IdShippingLine = Naviera.IdShippingLine;
                NuevoRegistro.IdCountryFinalDestination = PaisDestino.IdCountry;
                NuevoRegistro.IdDischargePort = PuertoDescarga.IdPort;
                NuevoRegistro.IdCountryDiscargePort = PaisDescarga.IdCountry;
                NuevoRegistro.IdVessel = Nave.IdVessel;

                NuevoRegistro.Num_DAE = fila.DAE;
                NuevoRegistro.Num_BL = fila.No_BL;
                NuevoRegistro.NumInvoiceSRI = fila.NFacturaSRI;
                NuevoRegistro.IdTypeOfShipment = TipoCarga.IdTypeOfShipment;

                int c1 = 0;
                int c2 = 0;

                int.TryParse(fila.NUM_CTNRS.ToString(), out c1);
                int.TryParse(fila.CAJASTARJA.ToString(), out c2);

                NuevoRegistro.NumBOXES = c2;
                NuevoRegistro.NumCNTRS = c1;
                NuevoRegistro.INV_1_FDL_OR_OTHER_EXPORTERS_FOB_PRICE_SRI = fila.PRECIO_FOB;
                //NuevoRegistro.FDL_OR_OTHER_EXPORTERS_FOB_AMOUNT_PRICE = fila.PRECIO_FOB;
                //NuevoRegistro.FDL_OR_OTHER_EXPORTERS_FOB_PRICE_REAL = fila.PRECIO_FOB;
                NuevoRegistro.FINAL_SALES_PRICE = 0;
                NuevoRegistro.FINAL_SALES_PRICE_AMOUNT = 0;
                NuevoRegistro.DateOfInvoice = fila.FECHA_EMISION_FACT_EXPORT;

                NuevoRegistro.IdBrand = Marca.IdBrand;
                NuevoRegistro.IdBoxType = TipoCaja.IdBoxType;
                NuevoRegistro.DescripcionProducto = fila.PRODUCTO;

                NuevoRegistro.ReleaseDate = fila.FECHA_RELEASE;
                NuevoRegistro.TotalKiloBruto = fila.KILOBRUTO;
                NuevoRegistro.TotalKiloNeto = fila.KILONETO;
                NuevoRegistro.cplan = fila.CPLAN;

                NuevoRegistro.FechaCreacion = DateTime.Now;
                NuevoRegistro.Activo = true;

                NuevoRegistro.IdCountry = paisEC.IdCountry;
                NuevoRegistro.IdTypeOfDocument = tipoDoc.IdTypeOfDocument;
                NuevoRegistro.UsuarioCreacion = "SYSTEM";

                _context.OrdenVentas.Add(NuevoRegistro);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
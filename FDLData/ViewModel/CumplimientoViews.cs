using FDLDATA.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricolaData.ViewModel
{
    public class CumplimientoViews
    {


    }
    //public class SubLaboresVM
    //{
    //    public SubLaboresVM()
    //    {
   
    //    }
    //    public SubLaboresVM(SubLabores  sub)
    //    {
    //        Nombre = sub.Nombre;
    //        IdSubLabor = sub.IdSubLabor;
    //        IdLabor = sub.IdLabor;
    //    }
    //    public string Nombre { get; set; }
    //    public long? IdSubLabor { get; set; }
    //    public long? IdLabor { get; set; }
    //}
    //public class CumplimientoViewModel
    //{
    //    public CumplimientoViewModel()
    //    {

    //    }
    //    public CumplimientoViewModel(Context ctx = null)
    //    {
    //        ItemsIncumplimiento = new List<ItemLaborCumplimiento>();
    //        LaboresModelo = new ItemLaborCumplimiento();
    //    }
     
    //    public DateTime? Fecha { set; get; }
    //    public int Periodo { set; get; }
    //    public int Semana { set; get; }
    //    public long? IdAdministrador { set; get; }
    //    public long? IdAuditor { set; get; }
    //    public long? IdCoordinadorCampo { set; get; }
    //    public string Hacienda { set; get; }
    //    public long? IdHacienda { set; get; }
    //    public long? IdLabor { set; get; }
    //    public ItemLaborCumplimiento LaboresModelo { get; set; }
    //    public List<ItemLaborCumplimiento> ItemsIncumplimiento;
    //}

    //public class ItemLaborCumplimiento
    //{
    //    public ItemLaborCumplimiento()
    //    {
     
    //    }
    //    public ItemLaborCumplimiento(Labores lab, Context ctx)
    //    {
    //        var lista = ctx.SubLabores.Where(x => x.IdLabor == lab.IdLabor).ToList();
    //        IdLabor = lab.IdLabor;
    //        Labor = lab.Nombre;
    //        SubLabores = lista.Select(c => new SubLaboresVM(c)).ToList();
    //        itemsLabor = new List<ItemsLaborDatos>();
    //    }
    //    public ItemLaborCumplimiento(Context ctx)
    //    {
    //        var lista = ctx.SubLabores.Where(x => x.Activo).ToList();
      
    //        SubLabores = lista.Select(c => new SubLaboresVM(c)).ToList();
    //    }
    //    public long? IdLabor { set; get; }
    //    public string Labor { get; set; }
    //    public List<ItemsLaborDatos> itemsLabor { get; set; }
    //    public List<SubLaboresVM> SubLabores { get; set; }


    //}
    public class ItemsLaborDatos
    {
        public int NumItem { set; get; }
        public long? IdLote { set; get; }
        public long? IdEmpleado { set; get; }
        public int CodigoLote { get; set; }
        public int Valor { set; get; }
        public long IdIncumplimiento { set; get; }
        public int ValorIncumplimiento { set; get; }
    }
}

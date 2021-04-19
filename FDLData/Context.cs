using Agricola.Seguridad;
using AgricolaData.Configuration;
using FDLDATA.Entities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDLDATA
{
    public class Context : SeguridadDbContext
    {
        //public Context(string connectionString) : base(connectionString)
        //{
        //}

        public Context() : base("DefaultConnection")
        {
        }

        // public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Cat_Usuarios> Cat_Usuarios { get; set; }       
        public virtual DbSet<NombresFilasTrack> NombresFilasTracks { get; set; }
        public virtual DbSet<ArchivoTracking> Archivos { get; set; }
        public virtual DbSet<FilasTracking> FilasTrackings { get; set; }

        public new static Context Create()
        {
            return new Context();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new Cat_UsuariosConfig());
            modelBuilder.Configurations.Add(new NombresFilasTrackConfig());

            modelBuilder.Configurations.Add(new ArchivoTracingConfig());
            modelBuilder.Configurations.Add(new FilasTrackingConfig());
        }
    }
}

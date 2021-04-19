﻿using Agricola.Seguridad;
using AgricolaData.Configuration;
using AgricolaData.Entities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoloData
{
    public class Context : SeguridadDbContext
    {
        //public Context(string connectionString) : base(connectionString)
        //{
        //}

        //public Context() : base("DefaultConnection")
        //{
        //}

        // public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Cat_Usuarios> Cat_Usuarios { get; set; }
   
   
        public new static Context Create()
        {
            return new Context();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new Cat_UsuariosConfig());
        }
    }
}

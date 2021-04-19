using FDLDATA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricolaData.Configuration
{

    public class Cat_UsuariosConfig : EntityTypeConfiguration<Cat_Usuarios>
    {
        public Cat_UsuariosConfig()
        {
            ToTable("Cat_Usuarios", "SEG");
            HasKey(x => x.IdUsuario);
        }
    }



}

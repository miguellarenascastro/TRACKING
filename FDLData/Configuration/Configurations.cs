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


    public class NombresFilasTrackConfig : EntityTypeConfiguration<NombresFilasTrack>
    {
        public NombresFilasTrackConfig()
        {
            ToTable("NombresFilasTrack", "BAS");
            HasKey(x => x.IdNombreFila);
        }
    }


    public class ArchivoTracingConfig : EntityTypeConfiguration<ArchivoTracking>
    {
        public ArchivoTracingConfig()
        {
            ToTable("ArchivoTracking", "BAS");
            HasKey(x => x.IdArchivoTracking);
        }
    }

    public class FilasTrackingConfig : EntityTypeConfiguration<FilasTracking>
    {
        public FilasTrackingConfig()
        {
            ToTable("FilasTracking", "BAS");
            HasKey(x => x.IdFilaTracking);

            HasRequired(x => x.ArchivoBase).WithMany().HasForeignKey(c => c.IdArchivo).WillCascadeOnDelete(false);



            Property(x => x.TOTAL_PESO_BRUTO)
                .HasPrecision(18, 5);

            Property(x => x.TOTAL_PESO_NETO)
                .HasPrecision(18, 5);
        }
    }


}

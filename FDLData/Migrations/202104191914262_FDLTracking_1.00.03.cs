namespace FDLDATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FDLTracking_10003 : DbMigration
    {
        public override void Up()
        {
            AddColumn("BAS.FilasTracking", "TIPO_CARGA", c => c.String());
            AddColumn("BAS.FilasTracking", "TIPO_CONTENEDOR", c => c.String());
            DropColumn("BAS.FilasTracking", "TIPO_CARGA_TIPO_CONTENEDOR");
        }
        
        public override void Down()
        {
            AddColumn("BAS.FilasTracking", "TIPO_CARGA_TIPO_CONTENEDOR", c => c.String());
            DropColumn("BAS.FilasTracking", "TIPO_CONTENEDOR");
            DropColumn("BAS.FilasTracking", "TIPO_CARGA");
        }
    }
}

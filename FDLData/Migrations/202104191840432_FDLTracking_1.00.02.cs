namespace FDLDATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FDLTracking_10002 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BAS.ArchivoTracking",
                c => new
                    {
                        IdArchivoTracking = c.Long(nullable: false, identity: true),
                        FechaCarga = c.DateTime(nullable: false),
                        UsuarioCarga = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(),
                        UsuarioModificacion = c.String(),
                        FechaModificacion = c.DateTime(),
                        UsuarioEliminacion = c.String(),
                        FechaEliminacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdArchivoTracking);
   
            
            CreateTable(
                "BAS.FilasTracking",
                c => new
                    {
                        IdFilaTracking = c.Long(nullable: false, identity: true),
                        IdArchivo = c.Long(nullable: false),
                        YEAR = c.Int(nullable: false),
                        WEEK = c.Int(nullable: false),
                        EXPORTED_BY = c.String(),
                        CONTRACT_TERMS = c.String(),
                        INCOTERM = c.String(),
                        CLIENTE_FACTURA_SRI = c.String(),
                        CLIENTE_GRUPO = c.String(),
                        CONSIGNEE = c.String(),
                        NOTIFY = c.String(),
                        PAIS_DESCARGA = c.String(),
                        PUERTO_DESCARGA = c.String(),
                        DESTINO_FINAL = c.String(),
                        VAPOR = c.String(),
                        LINEA_NAVIERA = c.String(),
                        DAE = c.String(),
                        NO_BL = c.String(),
                        TIPO_CAJA = c.String(),
                        TIPO_CARGA_TIPO_CONTENEDOR = c.String(),
                        MARCA = c.String(),
                        CNTRS = c.Int(nullable: false),
                        BOXES = c.Int(nullable: false),
                        TOTAL_PESO_BRUTO = c.Decimal(nullable: false, precision: 18, scale: 5),
                        TOTAL_PESO_NETO = c.Decimal(nullable: false, precision: 18, scale: 5),
                        Activo = c.Boolean(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(),
                        UsuarioModificacion = c.String(),
                        FechaModificacion = c.DateTime(),
                        UsuarioEliminacion = c.String(),
                        FechaEliminacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdFilaTracking)
                .ForeignKey("BAS.ArchivoTracking", t => t.IdArchivo)
                .Index(t => t.IdArchivo);
            
       
            
            CreateTable(
                "BAS.NombresFilasTrack",
                c => new
                    {
                        IdNombreFila = c.Long(nullable: false, identity: true),
                        NombreArchivo = c.String(),
                        NombreBase = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(),
                        UsuarioModificacion = c.String(),
                        FechaModificacion = c.DateTime(),
                        UsuarioEliminacion = c.String(),
                        FechaEliminacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdNombreFila);
                
    
        }
        
        public override void Down()
        {
            DropForeignKey("SGR.RolesUsuarios", "IdUsuario", "SGR.Usuarios");
            DropForeignKey("SGR.LoginsUsuarios", "IdUsuario", "SGR.Usuarios");
            DropForeignKey("SGR.ClaimsUsuarios", "IdUsuario", "SGR.Usuarios");
            DropForeignKey("SGR.RolesUsuarios", "IdRol", "SGR.Roles");
            DropForeignKey("SGR.SeguridadAreas", "SecurityLevel_IdNivel", "SGR.SeguridadNiveles");
            DropForeignKey("BAS.FilasTracking", "IdArchivo", "BAS.ArchivoTracking");
            DropForeignKey("SGR.Permisos", "IdArea", "SGR.SeguridadAreas");
            DropIndex("SGR.LoginsUsuarios", new[] { "IdUsuario" });
            DropIndex("SGR.ClaimsUsuarios", new[] { "IdUsuario" });
            DropIndex("SGR.Usuarios", "UserNameIndex");
            DropIndex("SGR.RolesUsuarios", new[] { "IdRol" });
            DropIndex("SGR.RolesUsuarios", new[] { "IdUsuario" });
            DropIndex("SGR.Roles", "RoleNameIndex");
            DropIndex("BAS.FilasTracking", new[] { "IdArchivo" });
            DropIndex("SGR.Permisos", new[] { "IdArea" });
            DropIndex("SGR.SeguridadAreas", new[] { "SecurityLevel_IdNivel" });
            DropTable("SGR.LoginsUsuarios");
            DropTable("SGR.ClaimsUsuarios");
            DropTable("SGR.Usuarios");
            DropTable("SGR.RolesUsuarios");
            DropTable("SGR.Roles");
            DropTable("BAS.NombresFilasTrack");
            DropTable("SGR.SeguridadNiveles");
            DropTable("BAS.FilasTracking");
            DropTable("SEG.Cat_Usuarios");
            DropTable("SGR.Permisos");
            DropTable("SGR.SeguridadAreas");
            DropTable("BAS.ArchivoTracking");
        }
    }
}

namespace Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Documento = c.String(maxLength: 11),
                        Apellidos = c.String(maxLength: 50),
                        Nombres = c.String(maxLength: 50),
                        RazonSocial = c.String(maxLength: 50),
                        Direccion = c.String(maxLength: 75),
                        Celular = c.String(maxLength: 15),
                        Imagen1 = c.Binary(),
                        Imagen2 = c.Binary(),
                        Imagen3 = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContratoEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        DireccionObra = c.String(maxLength: 75),
                        Referencia = c.String(maxLength: 150),
                        Observaciones = c.String(maxLength: 500),
                        IsCombustible = c.Boolean(nullable: false),
                        IsTransporte = c.Boolean(nullable: false),
                        ConceptoAdicional = c.String(maxLength: 50),
                        MontoAdicional = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClienteEntities", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.DetalleContratoEntities",
                c => new
                    {
                        ContratoId = c.Int(nullable: false),
                        EquipoId = c.Int(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ContratoId, t.EquipoId })
                .ForeignKey("dbo.ContratoEntities", t => t.ContratoId, cascadeDelete: true)
                .ForeignKey("dbo.EquipoEntities", t => t.EquipoId, cascadeDelete: true)
                .Index(t => t.ContratoId)
                .Index(t => t.EquipoId);
            
            CreateTable(
                "dbo.EquipoEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(maxLength: 8),
                        Tipo = c.String(maxLength: 25),
                        Descripcion = c.String(maxLength: 50),
                        Serie = c.String(maxLength: 25),
                        Marca = c.String(maxLength: 25),
                        Modelo = c.String(maxLength: 30),
                        IsDisponible = c.Boolean(nullable: false),
                        Imagen = c.Binary(),
                        Estado = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ConfigEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(maxLength: 25),
                        Value = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleContratoEntities", "EquipoId", "dbo.EquipoEntities");
            DropForeignKey("dbo.DetalleContratoEntities", "ContratoId", "dbo.ContratoEntities");
            DropForeignKey("dbo.ContratoEntities", "ClienteId", "dbo.ClienteEntities");
            DropIndex("dbo.DetalleContratoEntities", new[] { "EquipoId" });
            DropIndex("dbo.DetalleContratoEntities", new[] { "ContratoId" });
            DropIndex("dbo.ContratoEntities", new[] { "ClienteId" });
            DropTable("dbo.ConfigEntities");
            DropTable("dbo.EquipoEntities");
            DropTable("dbo.DetalleContratoEntities");
            DropTable("dbo.ContratoEntities");
            DropTable("dbo.ClienteEntities");
        }
    }
}

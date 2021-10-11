namespace Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConfigEntities", "Property", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.ClienteEntities", "Direccion", c => c.String(nullable: false, maxLength: 75));
            AlterColumn("dbo.ClienteEntities", "Celular", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.ContratoEntities", "DireccionObra", c => c.String(nullable: false, maxLength: 75));
            AlterColumn("dbo.EquipoEntities", "Codigo", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.EquipoEntities", "Tipo", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.EquipoEntities", "Descripcion", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.EquipoEntities", "Marca", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.EquipoEntities", "Modelo", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.EquipoEntities", "Estado", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.ConfigEntities", "Value", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.ConfigEntities", "Key");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ConfigEntities", "Key", c => c.String(maxLength: 25));
            AlterColumn("dbo.ConfigEntities", "Value", c => c.String(maxLength: 50));
            AlterColumn("dbo.EquipoEntities", "Estado", c => c.String(maxLength: 15));
            AlterColumn("dbo.EquipoEntities", "Modelo", c => c.String(maxLength: 30));
            AlterColumn("dbo.EquipoEntities", "Marca", c => c.String(maxLength: 25));
            AlterColumn("dbo.EquipoEntities", "Descripcion", c => c.String(maxLength: 50));
            AlterColumn("dbo.EquipoEntities", "Tipo", c => c.String(maxLength: 25));
            AlterColumn("dbo.EquipoEntities", "Codigo", c => c.String(maxLength: 8));
            AlterColumn("dbo.ContratoEntities", "DireccionObra", c => c.String(maxLength: 75));
            AlterColumn("dbo.ClienteEntities", "Celular", c => c.String(maxLength: 15));
            AlterColumn("dbo.ClienteEntities", "Direccion", c => c.String(maxLength: 75));
            DropColumn("dbo.ConfigEntities", "Property");
        }
    }
}

namespace Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clientenombrecompleto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteEntities", "NombreCompleto", c => c.String(maxLength: 150));
            DropColumn("dbo.ClienteEntities", "Apellidos");
            DropColumn("dbo.ClienteEntities", "Nombres");
            DropColumn("dbo.ClienteEntities", "RazonSocial");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClienteEntities", "RazonSocial", c => c.String(maxLength: 50));
            AddColumn("dbo.ClienteEntities", "Nombres", c => c.String(maxLength: 50));
            AddColumn("dbo.ClienteEntities", "Apellidos", c => c.String(maxLength: 50));
            DropColumn("dbo.ClienteEntities", "NombreCompleto");
        }
    }
}

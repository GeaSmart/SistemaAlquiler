namespace Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contenidocontrato : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContratoEntities", "Contenido", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContratoEntities", "Contenido");
        }
    }
}

namespace Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contratofieldsremove : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ContratoEntities", "IsCombustible");
            DropColumn("dbo.ContratoEntities", "IsTransporte");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContratoEntities", "IsTransporte", c => c.Boolean(nullable: false));
            AddColumn("dbo.ContratoEntities", "IsCombustible", c => c.Boolean(nullable: false));
        }
    }
}

namespace Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contractsfields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContratoEntities", "Estado", c => c.String(maxLength: 15));
            AddColumn("dbo.ContratoEntities", "ComentarioCierre", c => c.String(maxLength: 175));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContratoEntities", "ComentarioCierre");
            DropColumn("dbo.ContratoEntities", "Estado");
        }
    }
}

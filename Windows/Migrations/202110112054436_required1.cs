namespace Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClienteEntities", "Documento", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClienteEntities", "Documento", c => c.String(maxLength: 11));
        }
    }
}

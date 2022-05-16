namespace Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userentity4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserEntities", "Username", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.UserEntities", "Password", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserEntities", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.UserEntities", "Username", c => c.String(nullable: false));
        }
    }
}

namespace Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userentity3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserEntities", "Username", c => c.String(nullable: false));
            DropColumn("dbo.UserEntities", "User");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserEntities", "User", c => c.String(nullable: false));
            DropColumn("dbo.UserEntities", "Username");
        }
    }
}

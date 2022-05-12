namespace Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class equipofieldsupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EquipoEntities", "PrecioBaseDia", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.EquipoEntities", "IsDisponible");
            DropColumn("dbo.EquipoEntities", "Estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EquipoEntities", "Estado", c => c.String(nullable: false, maxLength: 15));
            AddColumn("dbo.EquipoEntities", "IsDisponible", c => c.Boolean(nullable: false));
            DropColumn("dbo.EquipoEntities", "PrecioBaseDia");
        }
    }
}

namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrdersTableImproove : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsOpen", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "IsOpen");
        }
    }
}

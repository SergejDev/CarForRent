namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OredersFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserProfile", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Autoes", "Order_OrderId", "dbo.Orders");
            DropIndex("dbo.UserProfile", new[] { "Order_OrderId" });
            DropIndex("dbo.Autoes", new[] { "Order_OrderId" });
            AddColumn("dbo.Orders", "AutoId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "ClientId", c => c.Int(nullable: false));
            AddForeignKey("dbo.Orders", "AutoId", "dbo.Autoes", "AutoId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "ClientId", "dbo.UserProfile", "UserId", cascadeDelete: true);
            CreateIndex("dbo.Orders", "AutoId");
            CreateIndex("dbo.Orders", "ClientId");
            DropColumn("dbo.UserProfile", "Order_OrderId");
            DropColumn("dbo.Autoes", "Order_OrderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Autoes", "Order_OrderId", c => c.Int());
            AddColumn("dbo.UserProfile", "Order_OrderId", c => c.Int());
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropIndex("dbo.Orders", new[] { "AutoId" });
            DropForeignKey("dbo.Orders", "ClientId", "dbo.UserProfile");
            DropForeignKey("dbo.Orders", "AutoId", "dbo.Autoes");
            DropColumn("dbo.Orders", "ClientId");
            DropColumn("dbo.Orders", "AutoId");
            CreateIndex("dbo.Autoes", "Order_OrderId");
            CreateIndex("dbo.UserProfile", "Order_OrderId");
            AddForeignKey("dbo.Autoes", "Order_OrderId", "dbo.Orders", "OrderId");
            AddForeignKey("dbo.UserProfile", "Order_OrderId", "dbo.Orders", "OrderId");
        }
    }
}

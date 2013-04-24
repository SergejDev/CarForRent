namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserProfile", "ClientInformationId", "dbo.Clients");
            DropIndex("dbo.UserProfile", new[] { "ClientInformationId" });
            AlterColumn("dbo.UserProfile", "ClientInformationId", c => c.Int());
            AddForeignKey("dbo.UserProfile", "ClientInformationId", "dbo.Clients", "ClientId");
            CreateIndex("dbo.UserProfile", "ClientInformationId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.UserProfile", new[] { "ClientInformationId" });
            DropForeignKey("dbo.UserProfile", "ClientInformationId", "dbo.Clients");
            AlterColumn("dbo.UserProfile", "ClientInformationId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserProfile", "ClientInformationId");
            AddForeignKey("dbo.UserProfile", "ClientInformationId", "dbo.Clients", "ClientId", cascadeDelete: true);
        }
    }
}

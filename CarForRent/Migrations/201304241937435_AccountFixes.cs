namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountFixes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserProfile", "ClientInformation_ClientId", "dbo.Clients");
            DropIndex("dbo.UserProfile", new[] { "ClientInformation_ClientId" });
            RenameColumn(table: "dbo.UserProfile", name: "ClientInformation_ClientId", newName: "ClientInformationId");
            AddForeignKey("dbo.UserProfile", "ClientInformationId", "dbo.Clients", "ClientId", cascadeDelete: true);
            CreateIndex("dbo.UserProfile", "ClientInformationId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.UserProfile", new[] { "ClientInformationId" });
            DropForeignKey("dbo.UserProfile", "ClientInformationId", "dbo.Clients");
            RenameColumn(table: "dbo.UserProfile", name: "ClientInformationId", newName: "ClientInformation_ClientId");
            CreateIndex("dbo.UserProfile", "ClientInformation_ClientId");
            AddForeignKey("dbo.UserProfile", "ClientInformation_ClientId", "dbo.Clients", "ClientId");
        }
    }
}

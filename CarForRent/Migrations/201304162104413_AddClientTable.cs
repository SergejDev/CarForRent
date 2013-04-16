namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        UserFirstName = c.String(nullable: false),
                        UserSecondName = c.String(nullable: false),
                        UserMidleName = c.String(nullable: false),
                        PassportNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
            AddColumn("dbo.UserProfile", "ClientInformation_ClientId", c => c.Int());
            AddForeignKey("dbo.UserProfile", "ClientInformation_ClientId", "dbo.Clients", "ClientId");
            CreateIndex("dbo.UserProfile", "ClientInformation_ClientId");
            DropColumn("dbo.UserProfile", "UserFirstName");
            DropColumn("dbo.UserProfile", "UserSecondName");
            DropColumn("dbo.UserProfile", "UserMidleName");
            DropColumn("dbo.UserProfile", "PassportNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "PassportNumber", c => c.String(nullable: false));
            AddColumn("dbo.UserProfile", "UserMidleName", c => c.String(nullable: false));
            AddColumn("dbo.UserProfile", "UserSecondName", c => c.String(nullable: false));
            AddColumn("dbo.UserProfile", "UserFirstName", c => c.String(nullable: false));
            DropIndex("dbo.UserProfile", new[] { "ClientInformation_ClientId" });
            DropForeignKey("dbo.UserProfile", "ClientInformation_ClientId", "dbo.Clients");
            DropColumn("dbo.UserProfile", "ClientInformation_ClientId");
            DropTable("dbo.Clients");
        }
    }
}

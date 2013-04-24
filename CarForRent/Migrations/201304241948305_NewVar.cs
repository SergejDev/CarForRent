namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewVar : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserProfile", "ClientInformationId", "dbo.Clients");
            DropIndex("dbo.UserProfile", new[] { "ClientInformationId" });
            AddColumn("dbo.UserProfile", "UserFirstName", c => c.String());
            AddColumn("dbo.UserProfile", "UserLastName", c => c.String());
            AddColumn("dbo.UserProfile", "UserMidleName", c => c.String());
            AddColumn("dbo.UserProfile", "PassportNumber", c => c.String());
            DropColumn("dbo.UserProfile", "ClientInformationId");
            DropTable("dbo.Clients");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        UserFirstName = c.String(),
                        UserLastName = c.String(),
                        UserMidleName = c.String(),
                        PassportNumber = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            AddColumn("dbo.UserProfile", "ClientInformationId", c => c.Int());
            DropColumn("dbo.UserProfile", "PassportNumber");
            DropColumn("dbo.UserProfile", "UserMidleName");
            DropColumn("dbo.UserProfile", "UserLastName");
            DropColumn("dbo.UserProfile", "UserFirstName");
            CreateIndex("dbo.UserProfile", "ClientInformationId");
            AddForeignKey("dbo.UserProfile", "ClientInformationId", "dbo.Clients", "ClientId");
        }
    }
}

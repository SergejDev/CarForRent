namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LmallFixes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "Login", c => c.String());
            AddColumn("dbo.Clients", "UserLastName", c => c.String(nullable: false));
            DropColumn("dbo.UserProfile", "UserName");
            DropColumn("dbo.Clients", "UserSecondName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "UserSecondName", c => c.String(nullable: false));
            AddColumn("dbo.UserProfile", "UserName", c => c.String());
            DropColumn("dbo.Clients", "UserLastName");
            DropColumn("dbo.UserProfile", "Login");
        }
    }
}

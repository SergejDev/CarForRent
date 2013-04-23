namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "UserName", c => c.String());
            DropColumn("dbo.UserProfile", "Login");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "Login", c => c.String());
            DropColumn("dbo.UserProfile", "UserName");
        }
    }
}

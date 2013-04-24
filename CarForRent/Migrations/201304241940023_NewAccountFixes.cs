namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewAccountFixes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "UserFirstName", c => c.String());
            AlterColumn("dbo.Clients", "UserLastName", c => c.String());
            AlterColumn("dbo.Clients", "UserMidleName", c => c.String());
            AlterColumn("dbo.Clients", "PassportNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "PassportNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "UserMidleName", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "UserLastName", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "UserFirstName", c => c.String(nullable: false));
        }
    }
}

namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autoes", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Autoes", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Autoes", "Number", c => c.Int(nullable: false));
            DropColumn("dbo.Autoes", "Quantity");
        }
    }
}

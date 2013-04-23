namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumberModyfied : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autoes", "Number", c => c.String(nullable: false));
            DropColumn("dbo.Autoes", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Autoes", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Autoes", "Number");
        }
    }
}

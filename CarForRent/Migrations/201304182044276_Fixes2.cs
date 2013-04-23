namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixes2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Autoes", "YearOfManufacture", c => c.Int());
            AlterColumn("dbo.Autoes", "EngineVolume", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Autoes", "EngineVolume", c => c.Double());
            AlterColumn("dbo.Autoes", "YearOfManufacture", c => c.DateTime());
        }
    }
}

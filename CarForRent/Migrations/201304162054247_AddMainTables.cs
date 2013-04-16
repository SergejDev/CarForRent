namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMainTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserFirstName = c.String(nullable: false),
                        UserSecondName = c.String(nullable: false),
                        UserMidleName = c.String(nullable: false),
                        PassportNumber = c.String(nullable: false),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.Autoes",
                c => new
                    {
                        AutoId = c.Int(nullable: false, identity: true),
                        Mark = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Number = c.Int(nullable: false),
                        YearOfManufacture = c.DateTime(),
                        PlacesCount = c.Byte(nullable: false),
                        EngineVolume = c.Double(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageFileName = c.String(),
                        AutoCount = c.Int(nullable: false),
                        AutoClass_AutoClassId = c.Int(),
                        EngineType_EngineTypeId = c.Int(),
                        GearboxType_GearboxTypeId = c.Int(),
                        FuelType_FuelTypeId = c.Int(),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.AutoId)
                .ForeignKey("dbo.AutoClasses", t => t.AutoClass_AutoClassId)
                .ForeignKey("dbo.EngineTypes", t => t.EngineType_EngineTypeId)
                .ForeignKey("dbo.GearboxTypes", t => t.GearboxType_GearboxTypeId)
                .ForeignKey("dbo.FuelTypes", t => t.FuelType_FuelTypeId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.AutoClass_AutoClassId)
                .Index(t => t.EngineType_EngineTypeId)
                .Index(t => t.GearboxType_GearboxTypeId)
                .Index(t => t.FuelType_FuelTypeId)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.AutoClasses",
                c => new
                    {
                        AutoClassId = c.Int(nullable: false, identity: true),
                        ClassTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AutoClassId);
            
            CreateTable(
                "dbo.EngineTypes",
                c => new
                    {
                        EngineTypeId = c.Int(nullable: false, identity: true),
                        EngineTypeTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EngineTypeId);
            
            CreateTable(
                "dbo.GearboxTypes",
                c => new
                    {
                        GearboxTypeId = c.Int(nullable: false, identity: true),
                        GearboxTypeTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GearboxTypeId);
            
            CreateTable(
                "dbo.FuelTypes",
                c => new
                    {
                        FuelTypeId = c.Int(nullable: false, identity: true),
                        FuelTypeTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FuelTypeId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDuration = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Autoes", new[] { "Order_OrderId" });
            DropIndex("dbo.Autoes", new[] { "FuelType_FuelTypeId" });
            DropIndex("dbo.Autoes", new[] { "GearboxType_GearboxTypeId" });
            DropIndex("dbo.Autoes", new[] { "EngineType_EngineTypeId" });
            DropIndex("dbo.Autoes", new[] { "AutoClass_AutoClassId" });
            DropIndex("dbo.UserProfile", new[] { "Order_OrderId" });
            DropForeignKey("dbo.Autoes", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Autoes", "FuelType_FuelTypeId", "dbo.FuelTypes");
            DropForeignKey("dbo.Autoes", "GearboxType_GearboxTypeId", "dbo.GearboxTypes");
            DropForeignKey("dbo.Autoes", "EngineType_EngineTypeId", "dbo.EngineTypes");
            DropForeignKey("dbo.Autoes", "AutoClass_AutoClassId", "dbo.AutoClasses");
            DropForeignKey("dbo.UserProfile", "Order_OrderId", "dbo.Orders");
            DropTable("dbo.Orders");
            DropTable("dbo.FuelTypes");
            DropTable("dbo.GearboxTypes");
            DropTable("dbo.EngineTypes");
            DropTable("dbo.AutoClasses");
            DropTable("dbo.Autoes");
            DropTable("dbo.UserProfile");
        }
    }
}

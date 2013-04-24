namespace CarForRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationshipsFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Autoes", "AutoClass_AutoClassId", "dbo.AutoClasses");
            DropForeignKey("dbo.Autoes", "EngineType_EngineTypeId", "dbo.EngineTypes");
            DropForeignKey("dbo.Autoes", "GearboxType_GearboxTypeId", "dbo.GearboxTypes");
            DropForeignKey("dbo.Autoes", "FuelType_FuelTypeId", "dbo.FuelTypes");
            DropIndex("dbo.Autoes", new[] { "AutoClass_AutoClassId" });
            DropIndex("dbo.Autoes", new[] { "EngineType_EngineTypeId" });
            DropIndex("dbo.Autoes", new[] { "GearboxType_GearboxTypeId" });
            DropIndex("dbo.Autoes", new[] { "FuelType_FuelTypeId" });
            RenameColumn(table: "dbo.Autoes", name: "AutoClass_AutoClassId", newName: "AutoClassId");
            RenameColumn(table: "dbo.Autoes", name: "EngineType_EngineTypeId", newName: "EngineTypeId");
            RenameColumn(table: "dbo.Autoes", name: "GearboxType_GearboxTypeId", newName: "GearboxTypeId");
            RenameColumn(table: "dbo.Autoes", name: "FuelType_FuelTypeId", newName: "FuelTypeId");
            AddForeignKey("dbo.Autoes", "AutoClassId", "dbo.AutoClasses", "AutoClassId", cascadeDelete: true);
            AddForeignKey("dbo.Autoes", "EngineTypeId", "dbo.EngineTypes", "EngineTypeId", cascadeDelete: true);
            AddForeignKey("dbo.Autoes", "GearboxTypeId", "dbo.GearboxTypes", "GearboxTypeId", cascadeDelete: true);
            AddForeignKey("dbo.Autoes", "FuelTypeId", "dbo.FuelTypes", "FuelTypeId", cascadeDelete: true);
            CreateIndex("dbo.Autoes", "AutoClassId");
            CreateIndex("dbo.Autoes", "EngineTypeId");
            CreateIndex("dbo.Autoes", "GearboxTypeId");
            CreateIndex("dbo.Autoes", "FuelTypeId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Autoes", new[] { "FuelTypeId" });
            DropIndex("dbo.Autoes", new[] { "GearboxTypeId" });
            DropIndex("dbo.Autoes", new[] { "EngineTypeId" });
            DropIndex("dbo.Autoes", new[] { "AutoClassId" });
            DropForeignKey("dbo.Autoes", "FuelTypeId", "dbo.FuelTypes");
            DropForeignKey("dbo.Autoes", "GearboxTypeId", "dbo.GearboxTypes");
            DropForeignKey("dbo.Autoes", "EngineTypeId", "dbo.EngineTypes");
            DropForeignKey("dbo.Autoes", "AutoClassId", "dbo.AutoClasses");
            RenameColumn(table: "dbo.Autoes", name: "FuelTypeId", newName: "FuelType_FuelTypeId");
            RenameColumn(table: "dbo.Autoes", name: "GearboxTypeId", newName: "GearboxType_GearboxTypeId");
            RenameColumn(table: "dbo.Autoes", name: "EngineTypeId", newName: "EngineType_EngineTypeId");
            RenameColumn(table: "dbo.Autoes", name: "AutoClassId", newName: "AutoClass_AutoClassId");
            CreateIndex("dbo.Autoes", "FuelType_FuelTypeId");
            CreateIndex("dbo.Autoes", "GearboxType_GearboxTypeId");
            CreateIndex("dbo.Autoes", "EngineType_EngineTypeId");
            CreateIndex("dbo.Autoes", "AutoClass_AutoClassId");
            AddForeignKey("dbo.Autoes", "FuelType_FuelTypeId", "dbo.FuelTypes", "FuelTypeId");
            AddForeignKey("dbo.Autoes", "GearboxType_GearboxTypeId", "dbo.GearboxTypes", "GearboxTypeId");
            AddForeignKey("dbo.Autoes", "EngineType_EngineTypeId", "dbo.EngineTypes", "EngineTypeId");
            AddForeignKey("dbo.Autoes", "AutoClass_AutoClassId", "dbo.AutoClasses", "AutoClassId");
        }
    }
}

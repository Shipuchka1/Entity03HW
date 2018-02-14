namespace Entity03HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationTablesManufacturer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.newEquipment",
                c => new
                    {
                        intEquipmentID = c.Int(nullable: false, identity: true),
                        intGarageRoom = c.String(maxLength: 50),
                        intManufacturerID = c.Int(nullable: false),
                        intModelID = c.Int(nullable: false),
                        strManufYear = c.String(maxLength: 4),
                        intSNPrefixID = c.Int(nullable: false),
                        strSerialNo = c.String(maxLength: 20),
                        intEquipmentTypeID = c.Int(nullable: false),
                        intSMCSFamilyID = c.Int(nullable: false),
                        intSizeID = c.Int(nullable: false),
                        CreateDate = c.DateTime(storeType: "date"),
                        intMetered = c.Double(nullable: false),
                        LastDate = c.DateTime(nullable: false, storeType: "date"),
                        intLastMetered = c.Double(nullable: false),
                        intTotalMetered = c.Double(nullable: false),
                        intlimitDay = c.Int(),
                        intlimitWeek = c.Int(),
                        bitActive = c.Boolean(nullable: false),
                        bitPreservation = c.Boolean(nullable: false),
                        bitMeter = c.Boolean(nullable: false),
                        bitKTG = c.Boolean(nullable: false),
                        isDelete = c.Boolean(nullable: false),
                        intLocationId = c.Int(nullable: false),
                        strDescription = c.String(maxLength: 1050),
                        floatCostTires = c.Double(),
                        intCostTiresCurrency = c.Int(),
                        floatAverageDivergence = c.Double(),
                        floatFullPrice = c.Double(),
                        intFullPriceCurrency = c.Int(),
                        dateStartUpDate = c.DateTime(storeType: "date"),
                        intServiceLife = c.Int(),
                        intHoweverOddsAcceleration = c.Int(),
                        bitMethodAmortization = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.intEquipmentID)
                .ForeignKey("dbo.TablesManufacturer", t => t.intManufacturerID)
                .ForeignKey("dbo.TablesModel", t => t.intModelID)
                .Index(t => t.intManufacturerID)
                .Index(t => t.intModelID);
            
            CreateTable(
                "dbo.TableEquipmentHistory",
                c => new
                    {
                        intEquipmentHistoryId = c.Int(nullable: false, identity: true),
                        intEquipmentID = c.Int(),
                        intTypeHistory = c.Int(),
                        dStartDate = c.DateTime(storeType: "date"),
                        dEndDate = c.DateTime(storeType: "date"),
                        intDaysCount = c.Int(),
                        intStatys = c.Int(),
                        intUserId = c.Int(),
                        dCahengeDate = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.intEquipmentHistoryId)
                .ForeignKey("dbo.newEquipment", t => t.intEquipmentID)
                .Index(t => t.intEquipmentID);
            
            CreateTable(
                "dbo.TablesManufacturer",
                c => new
                    {
                        intManufacturerID = c.Int(nullable: false, identity: true),
                        strManufacturerChecklistId = c.String(maxLength: 50),
                        strName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.intManufacturerID);
            
            CreateTable(
                "dbo.TablesModel",
                c => new
                    {
                        intModelID = c.Int(nullable: false, identity: true),
                        strName = c.String(maxLength: 10),
                        intManufacturerID = c.Int(),
                        intSMCSFamilyID = c.Int(),
                        strImage = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.intModelID)
                .ForeignKey("dbo.TablesManufacturer", t => t.intManufacturerID)
                .Index(t => t.intManufacturerID);
            Entity03HW.Program.SendMail("MigrationTablesManufacturer-Up");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TablesModel", "intManufacturerID", "dbo.TablesManufacturer");
            DropForeignKey("dbo.newEquipment", "intModelID", "dbo.TablesModel");
            DropForeignKey("dbo.newEquipment", "intManufacturerID", "dbo.TablesManufacturer");
            DropForeignKey("dbo.TableEquipmentHistory", "intEquipmentID", "dbo.newEquipment");
            DropIndex("dbo.TablesModel", new[] { "intManufacturerID" });
            DropIndex("dbo.TableEquipmentHistory", new[] { "intEquipmentID" });
            DropIndex("dbo.newEquipment", new[] { "intModelID" });
            DropIndex("dbo.newEquipment", new[] { "intManufacturerID" });
            DropTable("dbo.TablesModel");
            DropTable("dbo.TablesManufacturer");
            DropTable("dbo.TableEquipmentHistory");
            DropTable("dbo.newEquipment");
            Entity03HW.Program.SendMail("MigrationTablesManufacturer-Down");

        }
    }
}

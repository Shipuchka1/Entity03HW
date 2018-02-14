namespace Entity03HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationEquipmentCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipment",
                c => new
                    {
                        intEquipmentID = c.Int(nullable: false, identity: true),
                        intGarageRoom = c.String(maxLength: 50),
                        intManufacturerID = c.Int(nullable: false),
                        strManufYear = c.String(maxLength: 4),
                        intSNPrefixID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.intEquipmentID)
                .ForeignKey("dbo.Manufacturer", t => t.intManufacturerID)
                .Index(t => t.intManufacturerID);
            
            AddForeignKey("dbo.TableEquipmentHistory", "intEquipmentID", "dbo.Equipment", "intEquipmentID");
            Entity03HW.Program.SendMail("MigrationEquipmentCreate-Up");

        }

        public override void Down()
        {
            DropForeignKey("dbo.TableEquipmentHistory", "intEquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.Equipment", "intManufacturerID", "dbo.Manufacturer");
            DropIndex("dbo.Equipment", new[] { "intManufacturerID" });
            DropTable("dbo.Equipment");
            Entity03HW.Program.SendMail("MigrationEquipmentCreate-Down");

        }
    }
}

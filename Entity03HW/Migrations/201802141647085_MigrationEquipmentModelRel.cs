namespace Entity03HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationEquipmentModelRel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TableEquipmentHistory", "intEquipmentID", "dbo.Equipment");
            CreateIndex("dbo.Equipment", "intModelID");
            AddForeignKey("dbo.Equipment", "intModelID", "dbo.Model", "intModelID");
            Entity03HW.Program.SendMail("MigrationEquipmentModelRel-Up");

        }

        public override void Down()
        {
            DropForeignKey("dbo.Equipment", "intModelID", "dbo.Model");
            DropIndex("dbo.Equipment", new[] { "intModelID" });
            AddForeignKey("dbo.TableEquipmentHistory", "intEquipmentID", "dbo.Equipment", "intEquipmentID");
            Entity03HW.Program.SendMail("MigrationEquipmentModelRel-Down");

        }
    }
}

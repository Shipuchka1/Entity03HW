namespace Entity03HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationEquipmentChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "intModelID", c => c.Int(nullable: false));
            Entity03HW.Program.SendMail("MigrationEquipmentChange-Up");

        }

        public override void Down()
        {
            DropColumn("dbo.Equipment", "intModelID");
            Entity03HW.Program.SendMail("MigrationEquipmentChange-Down");

        }
    }
}

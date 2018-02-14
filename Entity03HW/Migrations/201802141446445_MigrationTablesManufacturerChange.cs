namespace Entity03HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationTablesManufacturerChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TablesManufacturer", "ManufacturerDescription", c => c.String(maxLength: 50));
            DropColumn("dbo.TablesManufacturer", "strManufacturerChecklistId");
            Entity03HW.Program.SendMail("MigrationTablesManufacturerChange-Up");

        }

        public override void Down()
        {
            AddColumn("dbo.TablesManufacturer", "strManufacturerChecklistId", c => c.String(maxLength: 50));
            DropColumn("dbo.TablesManufacturer", "ManufacturerDescription");
            Entity03HW.Program.SendMail("MigrationTablesManufacturerChange-Down");

        }
    }
}

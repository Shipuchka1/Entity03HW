namespace Entity03HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationTablesManufacturerRename : DbMigration
    {
        public override void Up()
        {

            RenameTable(name: "dbo.TablesManufacturer", newName: "Manufacturer");
            Entity03HW.Program.SendMail("MigrationTablesManufacturerRename-Up");

        }

        public override void Down()
        {
            RenameTable(name: "dbo.Manufacturer", newName: "TablesManufacturer");
            Entity03HW.Program.SendMail("MigrationTablesManufacturerRename-Down");

        }
    }
}

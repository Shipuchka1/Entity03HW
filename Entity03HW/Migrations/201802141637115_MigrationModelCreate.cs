namespace Entity03HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationModelCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Model",
                c => new
                    {
                        intModelID = c.Int(nullable: false, identity: true),
                        strName = c.String(maxLength: 50),
                        intManufacturerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.intModelID);
            Entity03HW.Program.SendMail("MigrationModelCreate-UP");

        }

        public override void Down()
        {
            DropTable("dbo.Model");
            Entity03HW.Program.SendMail("MigrationModelCreate-Down");

        }
    }
}

using System;
using System.Data.Entity.Migrations;

public partial class CreateDB1 : DbMigration
{
    public override void Up()
    {
        AddColumn("dbo.Invoices", "deleted", c => c.Boolean(nullable: false));
    }
    
    public override void Down()
    {
        DropColumn("dbo.Invoices", "deleted");
    }
}

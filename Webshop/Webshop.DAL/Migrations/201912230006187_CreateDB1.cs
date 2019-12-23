using System;
using System.Data.Entity.Migrations;

public partial class CreateDB1 : DbMigration
{
    public override void Up()
    {
        DropForeignKey("dbo.Courses", "InvoiceDetail_Id", "dbo.InvoiceDetails");
        DropIndex("dbo.Courses", new[] { "InvoiceDetail_Id" });
        DropColumn("dbo.Courses", "InvoiceDetail_Id");
    }
    
    public override void Down()
    {
        AddColumn("dbo.Courses", "InvoiceDetail_Id", c => c.Int());
        CreateIndex("dbo.Courses", "InvoiceDetail_Id");
        AddForeignKey("dbo.Courses", "InvoiceDetail_Id", "dbo.InvoiceDetails", "Id");
    }
}

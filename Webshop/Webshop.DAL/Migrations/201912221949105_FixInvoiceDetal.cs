using System;
using System.Data.Entity.Migrations;

public partial class FixInvoiceDetal : DbMigration
{
    public override void Up()
    {
        DropForeignKey("dbo.InvoiceDetails", "Invoice_Id", "dbo.Invoices");
        DropIndex("dbo.InvoiceDetails", new[] { "Invoice_Id" });
        RenameColumn(table: "dbo.InvoiceDetails", name: "Invoice_Id", newName: "InvoiceId");
        AlterColumn("dbo.InvoiceDetails", "InvoiceId", c => c.Int(nullable: false));
        CreateIndex("dbo.InvoiceDetails", "InvoiceId");
        AddForeignKey("dbo.InvoiceDetails", "InvoiceId", "dbo.Invoices", "Id", cascadeDelete: true);
    }
    
    public override void Down()
    {
        DropForeignKey("dbo.InvoiceDetails", "InvoiceId", "dbo.Invoices");
        DropIndex("dbo.InvoiceDetails", new[] { "InvoiceId" });
        AlterColumn("dbo.InvoiceDetails", "InvoiceId", c => c.Int());
        RenameColumn(table: "dbo.InvoiceDetails", name: "InvoiceId", newName: "Invoice_Id");
        CreateIndex("dbo.InvoiceDetails", "Invoice_Id");
        AddForeignKey("dbo.InvoiceDetails", "Invoice_Id", "dbo.Invoices", "Id");
    }
}

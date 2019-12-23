using System;
using System.Data.Entity.Migrations;

public partial class CreateDB : DbMigration
{
    public override void Up()
    {
        CreateTable(
            "dbo.Courses",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    InvoiceDetail_Id = c.Int(),
                    Product_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.InvoiceDetails", t => t.InvoiceDetail_Id)
            .ForeignKey("dbo.Products", t => t.Product_Id)
            .Index(t => t.InvoiceDetail_Id)
            .Index(t => t.Product_Id);
        
        CreateTable(
            "dbo.InvoiceDetails",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Pieces = c.Int(nullable: false),
                    CourseId = c.Int(nullable: false),
                    InvoiceId = c.Int(nullable: false),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Invoices", t => t.InvoiceId, cascadeDelete: true)
            .Index(t => t.InvoiceId);
        
        CreateTable(
            "dbo.Products",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Duration = c.Int(nullable: false),
                    StartDate = c.DateTime(nullable: false),
                    EndDate = c.DateTime(nullable: false),
                })
            .PrimaryKey(t => t.Id);
        
        CreateTable(
            "dbo.ProductPrices",
            c => new
                {
                    Id = c.Int(nullable: false),
                    ProductPrices = c.Decimal(nullable: false, precision: 18, scale: 2),
                    BeginDate = c.DateTime(nullable: false),
                    EndTime = c.DateTime(nullable: false),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Products", t => t.Id)
            .Index(t => t.Id);
        
        CreateTable(
            "dbo.Vats",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Percentage = c.Int(nullable: false),
                    Product_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Products", t => t.Product_Id)
            .Index(t => t.Product_Id);
        
        CreateTable(
            "dbo.Invoices",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    IsPaid = c.Boolean(nullable: false),
                    InvoiceCode = c.String(),
                    Deleted = c.Boolean(nullable: false),
                })
            .PrimaryKey(t => t.Id);
        
    }
    
    public override void Down()
    {
        DropForeignKey("dbo.InvoiceDetails", "InvoiceId", "dbo.Invoices");
        DropForeignKey("dbo.Vats", "Product_Id", "dbo.Products");
        DropForeignKey("dbo.ProductPrices", "Id", "dbo.Products");
        DropForeignKey("dbo.Courses", "Product_Id", "dbo.Products");
        DropForeignKey("dbo.Courses", "InvoiceDetail_Id", "dbo.InvoiceDetails");
        DropIndex("dbo.Vats", new[] { "Product_Id" });
        DropIndex("dbo.ProductPrices", new[] { "Id" });
        DropIndex("dbo.InvoiceDetails", new[] { "InvoiceId" });
        DropIndex("dbo.Courses", new[] { "Product_Id" });
        DropIndex("dbo.Courses", new[] { "InvoiceDetail_Id" });
        DropTable("dbo.Invoices");
        DropTable("dbo.Vats");
        DropTable("dbo.ProductPrices");
        DropTable("dbo.Products");
        DropTable("dbo.InvoiceDetails");
        DropTable("dbo.Courses");
    }
}

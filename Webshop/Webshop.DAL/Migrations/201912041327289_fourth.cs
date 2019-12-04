using System;
using System.Data.Entity.Migrations;

public partial class fourth : DbMigration
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
                    Product_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Products", t => t.Product_Id)
            .Index(t => t.Product_Id);
        
        CreateTable(
            "dbo.InvoiceDetails",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Pieces = c.Int(nullable: false),
                    Invoice_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Invoices", t => t.Invoice_Id)
            .Index(t => t.Invoice_Id);
        
        CreateTable(
            "dbo.Invoices",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    IsPaid = c.Boolean(nullable: false),
                    InvoiceCode = c.String(),
                })
            .PrimaryKey(t => t.Id);
        
        CreateTable(
            "dbo.ProductPrices",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ProductPrices = c.Decimal(nullable: false, precision: 18, scale: 2),
                    BeginDate = c.DateTime(nullable: false),
                    EndTime = c.DateTime(nullable: false),
                    Product_Id = c.Int(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Products", t => t.Product_Id)
            .Index(t => t.Product_Id);
        
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
            "dbo.CourseDTOes",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    price = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
            .PrimaryKey(t => t.Id);
        
    }
    
    public override void Down()
    {
        DropForeignKey("dbo.Vats", "Product_Id", "dbo.Products");
        DropForeignKey("dbo.ProductPrices", "Product_Id", "dbo.Products");
        DropForeignKey("dbo.Courses", "Product_Id", "dbo.Products");
        DropForeignKey("dbo.InvoiceDetails", "Invoice_Id", "dbo.Invoices");
        DropIndex("dbo.Vats", new[] { "Product_Id" });
        DropIndex("dbo.ProductPrices", new[] { "Product_Id" });
        DropIndex("dbo.InvoiceDetails", new[] { "Invoice_Id" });
        DropIndex("dbo.Courses", new[] { "Product_Id" });
        DropTable("dbo.CourseDTOes");
        DropTable("dbo.Vats");
        DropTable("dbo.Products");
        DropTable("dbo.ProductPrices");
        DropTable("dbo.Invoices");
        DropTable("dbo.InvoiceDetails");
        DropTable("dbo.Courses");
    }
}

namespace Webshop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Corrections : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "Products_Id", newName: "Product_Id");
            RenameColumn(table: "dbo.ProductPrices", name: "Products_Id", newName: "Product_Id");
            RenameColumn(table: "dbo.Vats", name: "Products_Id", newName: "Product_Id");
            RenameIndex(table: "dbo.Courses", name: "IX_Products_Id", newName: "IX_Product_Id");
            RenameIndex(table: "dbo.ProductPrices", name: "IX_Products_Id", newName: "IX_Product_Id");
            RenameIndex(table: "dbo.Vats", name: "IX_Products_Id", newName: "IX_Product_Id");
            AddColumn("dbo.Invoices", "IsPaid", c => c.Boolean(nullable: false));
            AddColumn("dbo.Vats", "Percentage", c => c.Int(nullable: false));
            DropColumn("dbo.Invoices", "Betaald");
            DropColumn("dbo.Vats", "Precentage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vats", "Precentage", c => c.Int(nullable: false));
            AddColumn("dbo.Invoices", "Betaald", c => c.Boolean(nullable: false));
            DropColumn("dbo.Vats", "Percentage");
            DropColumn("dbo.Invoices", "IsPaid");
            RenameIndex(table: "dbo.Vats", name: "IX_Product_Id", newName: "IX_Products_Id");
            RenameIndex(table: "dbo.ProductPrices", name: "IX_Product_Id", newName: "IX_Products_Id");
            RenameIndex(table: "dbo.Courses", name: "IX_Product_Id", newName: "IX_Products_Id");
            RenameColumn(table: "dbo.Vats", name: "Product_Id", newName: "Products_Id");
            RenameColumn(table: "dbo.ProductPrices", name: "Product_Id", newName: "Products_Id");
            RenameColumn(table: "dbo.Courses", name: "Product_Id", newName: "Products_Id");
        }
    }
}

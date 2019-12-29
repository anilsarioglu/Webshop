namespace Webshop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Product_Id", "dbo.Products");
            DropIndex("dbo.Courses", new[] { "Product_Id" });
            RenameColumn(table: "dbo.Courses", name: "Product_Id", newName: "ProductId");
            AlterColumn("dbo.Courses", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "ProductId");
            AddForeignKey("dbo.Courses", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "ProductId", "dbo.Products");
            DropIndex("dbo.Courses", new[] { "ProductId" });
            AlterColumn("dbo.Courses", "ProductId", c => c.Int());
            RenameColumn(table: "dbo.Courses", name: "ProductId", newName: "Product_Id");
            CreateIndex("dbo.Courses", "Product_Id");
            AddForeignKey("dbo.Courses", "Product_Id", "dbo.Products", "Id");
        }
    }
}

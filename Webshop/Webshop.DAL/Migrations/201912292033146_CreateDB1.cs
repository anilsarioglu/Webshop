namespace Webshop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InvoiceDetails", "ProductId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InvoiceDetails", "ProductId");
        }
    }
}

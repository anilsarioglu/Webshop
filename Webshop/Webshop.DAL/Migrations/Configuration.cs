using System.Data.Entity.Migrations;
using Webshop.DAL;
using Webshop.DAL.Entit;

internal sealed class Configuration : DbMigrationsConfiguration<Webshop.DAL.WebshopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Webshop.DAL.WebshopContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            foreach (Invoice invoice in DataHolder.GetInvoices())
            {
                context._Invoices.Add(invoice);
            }

            foreach(Product product in DataHolder.GetProducts())
            {
                context._Products.Add(product);
            }

            foreach (ProductPrice productPrice in DataHolder.GetProductPrices())
            {
                context._ProductPrices.Add(productPrice);
            }

            context.SaveChanges();
    }
}

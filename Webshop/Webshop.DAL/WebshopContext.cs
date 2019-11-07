using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Configuration;
using Webshop.DAL.Entit;

namespace Webshop.DAL
{
    class WebshopContext : DbContext,WebshopDataSource
    {
        public WebshopContext() : base("Webshop")
        {
        }
        public DbSet<Invoice> _Invoices { get; set; }
        public DbSet<InvoiceDetail> _InvoiceDetails { get; set; }
        public DbSet<Vat> _Vats { get; set; }
        public DbSet<Course> _Courses { get; set; }
        public DbSet<Products> _Productses { get; set; }
        public DbSet<ProductPrice> _ProductPrices { get; set; }
    



        IQueryable<Invoice> WebshopDataSource.Invoices => _Invoices;
        IQueryable<InvoiceDetail> WebshopDataSource.InvoiceDetails => _InvoiceDetails;
        IQueryable<Vat> WebshopDataSource.Vats => _Vats;
        IQueryable<Course> WebshopDataSource.Courses => _Courses;
        IQueryable<Products> WebshopDataSource.Product => _Productses;
        IQueryable<ProductPrice> WebshopDataSource.ProductPrices => _ProductPrices;

        public void CreateModelUser(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VatConfiguration());
            modelBuilder.Configurations.Add(new InvoiceConfiguration());
            modelBuilder.Configurations.Add(new InvoiceDetailConfiguration());
            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ProductPriceConfiguration());

        }
        public void Save()
        {
            SaveChanges();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL
{
    public static class DataHolder
    {
        public static List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>
            {
                new Course("Entity Framework", 150),
                new Course("Unit Testing", 80),
                new Course("ASP.NET MVC", 200),
                new Course("ASP.NET Web API", 130),
                new Course("Blazor", 300),
                new Course("Identity Framework", 180),
                new Course("Fundamentals", 100),
                new Course("Front End", 200),
                new Course("History of .NET", 75),
                new Course("NHibernate", 200)
            };

            return courses;
        }

        public static List<InvoiceDetail> GetInvoiceDetails()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>
            {
                new InvoiceDetail(5),
                new InvoiceDetail(11),
                new InvoiceDetail(6),
                new InvoiceDetail(13),
                new InvoiceDetail(9),
                new InvoiceDetail(2),
                new InvoiceDetail(7),
                new InvoiceDetail(32),
                new InvoiceDetail(20),
                new InvoiceDetail(14)
            };

            return invoiceDetails;
        }

        public static List<DetailCourse> GetDetailCourses()
        {
            List<DetailCourse> detailCourses = new List<DetailCourse>();

            for(int i = 0; i < 10; i++)
            {
                detailCourses.Add(new DetailCourse(GetCourses().ElementAt(i), GetInvoiceDetails().ElementAt(i), i));
            }

            return detailCourses;
        }

        public static List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>
            {
                new Invoice(DateTime.Now, true, "randomCode123", GetInvoiceDetails()),
                new Invoice(DateTime.Now, false, "random123", GetInvoiceDetails()),
                new Invoice(DateTime.Now, true, "Code123", GetInvoiceDetails()),
                new Invoice(DateTime.Now, true, "randomCode", GetInvoiceDetails()),
                new Invoice(DateTime.Now, false, "randomCode548", GetInvoiceDetails()),
                new Invoice(DateTime.Now, false, "randomCo23", GetInvoiceDetails()),
                new Invoice(DateTime.Now, true, "randCode3", GetInvoiceDetails()),
                new Invoice(DateTime.Now, true, "random", GetInvoiceDetails()),
                new Invoice(DateTime.Now, false, "123548", GetInvoiceDetails()),
                new Invoice(DateTime.Now, true, "ra123", GetInvoiceDetails())
            };

            return invoices;
        }

        public static List<InvoiceDetailProduct> GetInvoiceDetailProducts()
        {
            List<InvoiceDetailProduct> invoiceDetailProducts = new List<InvoiceDetailProduct>();

            for (int i = 0; i < 10; i++)
            {
                invoiceDetailProducts.Add(new InvoiceDetailProduct(GetInvoiceDetails().ElementAt(i), null, i));
            }

            return invoiceDetailProducts;
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product("Angular", 20, DateTime.Now, DateTime.Now, GetCourses(), GetVats(), GetProductPrices()),
                new Product("Vue", 10, DateTime.Now, DateTime.Now, GetCourses(), GetVats(), GetProductPrices()),
                new Product("Sass", 10, DateTime.Now, DateTime.Now, GetCourses(), GetVats(), GetProductPrices()),
                new Product("React", 30, DateTime.Now, DateTime.Now, GetCourses(), GetVats(), GetProductPrices()),
                new Product("TypeScript", 10, DateTime.Now, DateTime.Now, GetCourses(), GetVats(), GetProductPrices()),
                new Product("Django", 5, DateTime.Now, DateTime.Now, GetCourses(), GetVats(), GetProductPrices()),
                new Product("Express", 5, DateTime.Now, DateTime.Now, GetCourses(), GetVats(), GetProductPrices()),
                new Product("CouchDb", 15, DateTime.Now, DateTime.Now, GetCourses(), GetVats(), GetProductPrices()),
                new Product("MongoDb", 20, DateTime.Now, DateTime.Now, GetCourses(), GetVats(), GetProductPrices()),
                new Product("Ionic", 40, DateTime.Now, DateTime.Now, GetCourses(), GetVats(), GetProductPrices())
            };

            return products;
        }

        public static List<ProductPrice> GetProductPrices()
        {
            List<ProductPrice> productPrices = new List<ProductPrice>
            {
                new ProductPrice(20, DateTime.Now, DateTime.Now),
                new ProductPrice(10, DateTime.Now, DateTime.Now),
                new ProductPrice(10, DateTime.Now, DateTime.Now),
                new ProductPrice(30, DateTime.Now, DateTime.Now),
                new ProductPrice(10, DateTime.Now, DateTime.Now),
                new ProductPrice(5, DateTime.Now, DateTime.Now),
                new ProductPrice(5, DateTime.Now, DateTime.Now),
                new ProductPrice(15, DateTime.Now, DateTime.Now),
                new ProductPrice(20, DateTime.Now, DateTime.Now),
                new ProductPrice(40, DateTime.Now, DateTime.Now)
            };


            return productPrices;
        }

        public static List<Vat> GetVats()
        {
            List<Vat> vats = new List<Vat>
            {
                new Vat(0),
                new Vat(6),
                new Vat(12),
                new Vat(21)
            };

            return vats;
        }
    }
}

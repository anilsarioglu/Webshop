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
                new Course("Entity Framework", 150, null, null),
                new Course("Unit Testing", 80, null, null),
                new Course("ASP.NET MVC", 200, null, null),
                new Course("ASP.NET Web API", 130, null, null),
                new Course("Blazor", 300, null, null),
                new Course("Identity Framework", 180, null, null),
                new Course("Fundamentals", 100, null, null),
                new Course("Front End", 200, null, null),
                new Course("History of .NET", 75, null, null),
                new Course("NHibernate", 200, null, null)
            };

            return courses;
        }

        private static List<Course> GetMobileCourses()
        {
            List<Course> courses = new List<Course>
            {
                new Course("Objective C", 50, null, null),
                new Course("Ionic", 50, null, null),
                new Course("Android Studio", 20, null, null),
            };

            return courses;
        }

        private static List<Course> GetTestingCourses()
        {
            List<Course> courses = new List<Course>
            {
                new Course("Unit testing", 50, null, null),
                new Course("Functional testing", 15, null, null),
                new Course("Regression testing", 15, null, null),
            };

            return courses;
        }

        private static List<Course> GetAdvancedCourses()
        {
            List<Course> courses = new List<Course>
            {
                new Course("Blazor", 50, null, null),
                new Course("History of .NET", 10, null, null),
                new Course("NHibernate", 30, null, null),
            };

            return courses;
        }

        private static List<Course> GetBasicsCourses()
        {
            List<Course> courses = new List<Course>
            {
                new Course("Entity Framework", 20, null, null),
                new Course("Web API", 30, null, null),
                new Course("MVC", 30, null, null),
            };

            return courses;
        }

        private static List<Course> GetFrontEndCourses()
        {
            List<Course> courses = new List<Course>
            {
                new Course("Sass", 20, null, null),
                new Course("Vue", 20, null, null),
                new Course("Bootstrap", 30, null, null),
            };

            return courses;
        }

        public static List<InvoiceDetail> GetInvoiceDetails()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>
            {
                new InvoiceDetail(5, null, GetFrontEndCourses().ElementAt(0)),
                new InvoiceDetail(11, null, GetFrontEndCourses().ElementAt(1)),
                new InvoiceDetail(6, null, GetFrontEndCourses().ElementAt(2)),
                new InvoiceDetail(13, null, null),
                new InvoiceDetail(9, null, null),
                new InvoiceDetail(2, null, null),
                new InvoiceDetail(7, null, null),
                new InvoiceDetail(32, null, null),
                new InvoiceDetail(20, null, null),
                new InvoiceDetail(14, null, null)
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
                new Product("Front-end", 20, DateTime.Now, DateTime.Now, GetFrontEndCourses(), GetVats(), null),
                new Product(".NET Basics", 10, DateTime.Now, DateTime.Now, GetBasicsCourses(), GetVats(), null),
                new Product(".NET Advanced", 10, DateTime.Now, DateTime.Now, GetAdvancedCourses(), GetVats(), null),
                new Product("Testing", 30, DateTime.Now, DateTime.Now, GetTestingCourses(), GetVats(), null),
                new Product("Mobile", 10, DateTime.Now, DateTime.Now, GetMobileCourses(), GetVats(), null),
            };

            return products;
        }

        public static List<ProductPrice> GetProductPrices()
        {
            List<ProductPrice> productPrices = new List<ProductPrice>
            {
                new ProductPrice(70, DateTime.Now, DateTime.Now, GetProducts().ElementAt(0)),
                new ProductPrice(80, DateTime.Now, DateTime.Now, GetProducts().ElementAt(1)),
                new ProductPrice(10, DateTime.Now, DateTime.Now, GetProducts().ElementAt(2)),
                new ProductPrice(30, DateTime.Now, DateTime.Now, GetProducts().ElementAt(3)),
                new ProductPrice(10, DateTime.Now, DateTime.Now, GetProducts().ElementAt(4)),
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

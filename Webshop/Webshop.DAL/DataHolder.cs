using System;
using System.Collections.Generic;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL
{
    public static class DataHolder
    {
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

        public static List<InvoiceDetail> GetFrontEndInvoiceDetails()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>
            {
                new InvoiceDetail(7, null, GetFrontEndCourses().ElementAt(0)),
                new InvoiceDetail(9, null, GetFrontEndCourses().ElementAt(1)),
                new InvoiceDetail(6, null, GetFrontEndCourses().ElementAt(2)),
            };

            return invoiceDetails;
        }

        public static List<InvoiceDetail> GetBasicsInvoiceDetails()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>
            {
                new InvoiceDetail(15, null, GetBasicsCourses().ElementAt(0)),
                new InvoiceDetail(15, null, GetBasicsCourses().ElementAt(1)),
                new InvoiceDetail(10, null, GetBasicsCourses().ElementAt(2)),
            };

            return invoiceDetails;
        }

        public static List<InvoiceDetail> GetAdvancedInvoiceDetails()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>
            {
                new InvoiceDetail(5, null, GetAdvancedCourses().ElementAt(0)),
                new InvoiceDetail(11, null, GetAdvancedCourses().ElementAt(1)),
                new InvoiceDetail(6, null, GetAdvancedCourses().ElementAt(2)),
            };

            return invoiceDetails;
        }

        public static List<InvoiceDetail> GetTestingInvoiceDetails()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>
            {
                new InvoiceDetail(10, null, GetTestingCourses().ElementAt(0)),
                new InvoiceDetail(3, null, GetTestingCourses().ElementAt(1)),
                new InvoiceDetail(2, null, GetTestingCourses().ElementAt(2)),
            };

            return invoiceDetails;
        }

        public static List<InvoiceDetail> GetMobileInvoiceDetails()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>
            {
                new InvoiceDetail(7, null, GetMobileCourses().ElementAt(0)),
                new InvoiceDetail(15, null, GetMobileCourses().ElementAt(1)),
                new InvoiceDetail(3, null, GetMobileCourses().ElementAt(2)),
            };

            return invoiceDetails;
        }

        public static List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>
            {
                new Invoice(DateTime.Now, true, "randomCode123", GetFrontEndInvoiceDetails()),
                new Invoice(DateTime.Now, false, "random123", GetBasicsInvoiceDetails()),
                new Invoice(DateTime.Now, true, "Code123", GetAdvancedInvoiceDetails()),
                new Invoice(DateTime.Now, true, "randomCode", GetTestingInvoiceDetails()),
                new Invoice(DateTime.Now, false, "randomCode548", GetMobileInvoiceDetails()),
            };

            return invoices;
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

using System;
using System.Collections.Generic;

namespace Webshop.DAL.Entit
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public InvoiceDetail InvoiceDetail { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Vat> Vats { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }

        public Product()
        {

        }

        public Product(string name, int duration, DateTime startDate, DateTime endDate, InvoiceDetail invoiceDetail, ICollection<Course> courses, ICollection<Vat> vats, ICollection<ProductPrice> productPrices)
        {
            Name = name;
            Duration = duration;
            StartDate = startDate;
            EndDate = endDate;
            InvoiceDetail = invoiceDetail;
            Courses = courses;
            Vats = vats;
            ProductPrices = productPrices;
        }
    }
}

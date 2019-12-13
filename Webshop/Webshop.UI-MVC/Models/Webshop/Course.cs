using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshop.UI_MVC.Models.Webshop
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public InvoiceDetail InvoiceDetail { get; set; }
        public Product Product { get; set; }
    }
}
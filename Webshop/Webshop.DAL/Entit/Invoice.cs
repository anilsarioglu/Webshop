using System;
using System.Collections.Generic;

namespace Webshop.DAL.Entit
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsPaid { get; set; }
        public string InvoiceCode { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
       
    }
}

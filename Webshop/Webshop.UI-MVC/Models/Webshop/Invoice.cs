using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshop.UI_MVC.Models.Webshop
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsPaid { get; set; }
        public string InvoiceCode { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public Invoice()
        {
                
        }
        public Invoice(DateTime date, bool isPaid, string invoiceCode)
        {
            this.InvoiceDetails = new List<InvoiceDetail>();
            this.Date = date;
            this.IsPaid = isPaid;
            this.InvoiceCode = invoiceCode;
        }
    }
}
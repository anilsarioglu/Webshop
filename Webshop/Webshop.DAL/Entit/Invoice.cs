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
        public bool Deleted { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public Invoice(DateTime date, bool isPaid, bool deleted, string invoiceCode,
            ICollection<InvoiceDetail> invoiceDetails)
        {
            this.Date = date;
            this.IsPaid = isPaid;
            this.Deleted = deleted;
            this.InvoiceCode = invoiceCode;
            this.InvoiceDetails = invoiceDetails;
        }

        public Invoice()
        {
        }
    }
}
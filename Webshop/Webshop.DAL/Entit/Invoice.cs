using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.DAL.Entit
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Betaald { get; set; }
        public InvoiceDetail InvoiceDetail { get; set; }
        public int InvoiceDetailId { get; set; }
    }
}

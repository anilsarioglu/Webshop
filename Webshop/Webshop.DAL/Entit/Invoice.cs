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
        public string InvoiceCode { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
       
    }
}

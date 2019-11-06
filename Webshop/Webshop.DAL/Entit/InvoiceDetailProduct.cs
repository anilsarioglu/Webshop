using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.DAL.Entit
{
    class InvoiceDetailProduct
    {
        public InvoiceDetail InvoiceDetail { get; set; }
        public int InvoiceDetailId { get; set; }
        public Products Products { get; set; }
        public int ProductId { get; set; }
    }
}

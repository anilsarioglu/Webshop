using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Domain
{
    public class InvoiceDetailDTO
    {
        public int Id { get; set; }
        public int Pieces { get; set; }
        public InvoiceDTO InvoiceDto { get; set; }
        public int InvoiceId { get; set; }    
    }
}

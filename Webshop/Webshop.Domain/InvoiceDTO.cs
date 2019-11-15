﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Domain
{
    public class InvoiceDTO
    {
        public class Invoice
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public bool IsPaid { get; set; }
            public string InvoiceCode { get; set; }
            public ICollection<InvoiceDetailDTO> InvoiceDetails { get; set; }

        }
    }
}
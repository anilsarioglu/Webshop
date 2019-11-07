using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;

namespace Webshop.DAL
{
    interface WebshopDataSource
    {
        IQueryable<Invoice> Invoices { get; }
        IQueryable<InvoiceDetail> InvoiceDetails { get; }
        IQueryable<Vat> Vats { get; }
        IQueryable<Course> Courses { get; }
        IQueryable<Products> Product { get; }
        IQueryable<ProductPrice> ProductPrices { get; }
        void Save();
    }
}

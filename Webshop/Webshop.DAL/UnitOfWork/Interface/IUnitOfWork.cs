using System;
using Webshop.DAL.Repositories;

namespace Webshop.DAL.UnitOfWork.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        CourseRepo Courses { get; }
        InvoiceDetailRepo InvoiceDetails { get; }
        InvoiceRepo Invoices { get; }
        ProductPriceRepo ProductPrices { get; }
        ProductRepo Products { get; }
        VatRepo Vats { get; }

        int SaveChanges();
    }
}

using Webshop.DAL.Repositories;
using Webshop.DAL.UnitOfWork.Interface;

namespace Webshop.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebshopContext _context;

        public CourseRepo Courses { get; private set; }
        public InvoiceDetailRepo InvoiceDetails { get; private set; }
        public InvoiceRepo Invoices { get; private set; }
        public ProductPriceRepo ProductPrices { get; private set; }
        public ProductRepo Products { get; private set; }
        public VatRepo Vats { get; private set; }

        public UnitOfWork()
        {
            _context = new WebshopContext();

            Courses = new CourseRepo(_context);
            InvoiceDetails = new InvoiceDetailRepo(_context);
            Invoices = new InvoiceRepo(_context);
            ProductPrices = new ProductPriceRepo(_context);
            Products = new ProductRepo(_context);
            Vats = new VatRepo(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

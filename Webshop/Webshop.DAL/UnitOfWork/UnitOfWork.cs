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

        public UnitOfWork(WebshopContext context)
        {
            _context = context;
            Courses = new CourseRepo(context);
            InvoiceDetails = new InvoiceDetailRepo(context);
            Invoices = new InvoiceRepo(context);
            ProductPrices = new ProductPriceRepo(context);
            Products = new ProductRepo(context);
            Vats = new VatRepo(context);
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

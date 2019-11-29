using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.DAL.UnitOfWork.Interface;

namespace Webshop.DAL.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly WebshopContext _context;

        public IRepository<Course> Courses { get; private set; }
        public IRepository<InvoiceDetail> InvoiceDetails { get; private set; }
        public IRepository<Invoice> Invoices { get; private set; }
        public IRepository<ProductPrice> ProductPrices { get; private set; }
        public IRepository<Product> Products { get; private set; }
        public IRepository<Vat> Vats { get; private set; }

        public UnitOfWork(WebshopContext context, CourseRepo courseRepo, InvoiceDetailRepo invoiceDetailRepo, InvoiceRepo invoiceRepo,
            ProductPriceRepo productPriceRepo, ProductRepo productRepo, VatRepo vatRepo)
        {
            _context = context;

            Courses = courseRepo;
            InvoiceDetails = invoiceDetailRepo;
            Invoices = invoiceRepo;
            ProductPrices = productPriceRepo;
            Products = productRepo;
            Vats = vatRepo;
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

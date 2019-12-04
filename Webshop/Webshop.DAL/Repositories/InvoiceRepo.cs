using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class InvoiceRepo : IRepository<Invoice>
    {
        private WebshopContext _webshopContext;
        public InvoiceRepo(WebshopContext context)
        {
            _webshopContext = context;
        }

        public void Add(Invoice t)
        {
            _webshopContext._Invoices.Add(t);
        }

        public Invoice FindById(int? id)
        {
            return _webshopContext._Invoices.Find(id);
        }

        public void Modify(Invoice invoice)
        {
            _webshopContext._Invoices.AddOrUpdate(invoice);
        }

        public List<Invoice> GetAll()
        {
            return _webshopContext._Invoices.ToList();
        }

        public void Remove(Invoice t)
        {
            _webshopContext._Invoices.Remove(t);
            //_webshopContext.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            //_webshopContext.SaveChanges();
        }
    }
}

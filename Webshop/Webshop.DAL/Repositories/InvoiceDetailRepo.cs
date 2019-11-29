using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class InvoiceDetailRepo : IRepository<InvoiceDetail>
    {
        private WebshopContext _webshopContext;
        public InvoiceDetailRepo(WebshopContext context)
        {
            _webshopContext = context;
        }

        public void Add(InvoiceDetail t)
        {
            _webshopContext._InvoiceDetails.Add(t);
            _webshopContext._Invoices.Attach(t.Invoice);
            _webshopContext.Entry(t.Invoice).State = EntityState.Unchanged;

        }

        public InvoiceDetail FindById(int? id)
        {
            return _webshopContext._InvoiceDetails.Find(id);
        }

        public void Modify(InvoiceDetail t)
        {
            _webshopContext._InvoiceDetails.AddOrUpdate(t);
            _webshopContext._Invoices.Attach(t.Invoice);
            _webshopContext.Entry(t.Invoice).State = EntityState.Modified;


        }

        public List<InvoiceDetail> GetAll()
        {
            return _webshopContext._InvoiceDetails.ToList();
        }

        public void Remove(InvoiceDetail t)
        {
            _webshopContext._InvoiceDetails.Remove(t);
        }
    }
}

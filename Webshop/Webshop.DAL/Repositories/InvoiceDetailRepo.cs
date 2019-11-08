using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class InvoiceDetailRepo : IRepository<InvoiceDetail>
    {
        private WebshopContext _webshopContext = new WebshopContext();

        public void Create(InvoiceDetail t)
        {
            _webshopContext._InvoiceDetails.Add(t);
            _webshopContext.SaveChanges();
        }

        public InvoiceDetail Read(int? id)
        {
            return _webshopContext._InvoiceDetails.Find(id);
        }

        public void Update()
        {
            _webshopContext._InvoiceDetails.AddOrUpdate();
        }

        public List<InvoiceDetail> ReadAll()
        {
            return _webshopContext._InvoiceDetails.ToList();
        }

        public void Delete(InvoiceDetail t)
        {
            _webshopContext._InvoiceDetails.Remove(t);
        }
    }
}

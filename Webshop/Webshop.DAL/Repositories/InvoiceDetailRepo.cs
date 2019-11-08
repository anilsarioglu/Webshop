using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class InvoiceDetailRepo : IRepository<InvoiceDetail>
    {
        private WebshopContext _webshopContext = new WebshopContext();

        public void Add(InvoiceDetail t)
        {
            _webshopContext._InvoiceDetails.Add(t);
            _webshopContext.SaveChanges();
        }

        public InvoiceDetail FindById(int? id)
        {
            return _webshopContext._InvoiceDetails.Find(id);
        }

        public void Modify()
        {
            _webshopContext._InvoiceDetails.AddOrUpdate();
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

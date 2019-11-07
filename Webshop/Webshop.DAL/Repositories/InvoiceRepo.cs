using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class InvoiceRepo : IRepository<Invoice>
    {
        private WebshopContext _webshopContext = new WebshopContext();

        public void Add(Invoice t)
        {
            _webshopContext._Invoices.Add(t);
            _webshopContext.SaveChanges();
        }

        public Invoice FinById(int? id)
        {
            return _webshopContext._Invoices.Find(id);
        }

        public void Modify()
        {
            _webshopContext._Invoices.AddOrUpdate();
            _webshopContext.SaveChanges();
        }

        public List<Invoice> GetAll()
        {
            return _webshopContext._Invoices.ToList();
        }

        public void Remove(Invoice t)
        {
            _webshopContext._Invoices.Remove(t);
            _webshopContext.SaveChanges();
        }
    }
}

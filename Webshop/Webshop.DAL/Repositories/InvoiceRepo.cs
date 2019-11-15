using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class InvoiceRepo : IRepository<Invoice>
    {
        private WebshopContext _webshopContext = new WebshopContext();

        public void Create(Invoice t)
        {
            _webshopContext._Invoices.Add(t);
            _webshopContext.SaveChanges();
        }

        public Invoice Read(int? id)
        {
            return _webshopContext._Invoices.Find(id);
        }

        public void Update()
        {
            _webshopContext._Invoices.AddOrUpdate();
            _webshopContext.SaveChanges();
        }

        public List<Invoice> GetAll()
        {
            return _webshopContext._Invoices.ToList();
        }

        public void Delete(Invoice t)
        {
            _webshopContext._Invoices.Remove(t);
            _webshopContext.SaveChanges();
        }

    public void insertData()
    {
      List<Invoice> invoices = DataHolder.GetInvoices();
      for (int i = 0; i < invoices.Count; i++)
      {
        Invoice invoice = invoices[i];
        invoice.Id = i;
        _webshopContext._Invoices.Add(invoice);
      }
      _webshopContext.SaveChanges();
      //foreach (Invoice item in DataHolder.GetInvoices())
      //{
      //  _webshopContext._Invoices.Add(item);
      //}
      //_webshopContext.SaveChanges();
    }
    }
}

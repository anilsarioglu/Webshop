using System;
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
            try
            {
                _webshopContext._InvoiceDetails.Add(t);
                _webshopContext._Invoices.Attach(t.Invoice);
                _webshopContext.Entry(t.Invoice).State = EntityState.Unchanged;
            }
            catch (Exception e)
            {
               
                throw new Exception(e.Message);
            }
           

        }

        public InvoiceDetail FindById(int? id)
        {
            try
            {
                return _webshopContext._InvoiceDetails.Find(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Modify(InvoiceDetail t)
        {
            try
            {
                _webshopContext._InvoiceDetails.AddOrUpdate(t);
                _webshopContext._Invoices.Attach(t.Invoice);
                _webshopContext.Entry(t.Invoice).State = EntityState.Modified;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }


        }

        public List<InvoiceDetail> GetAll()
        {
            try
            {
                return _webshopContext._InvoiceDetails.ToList();
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
            
        }

        public void Remove(InvoiceDetail t)
        {
            try
            {
                _webshopContext.Entry(t).State = EntityState.Deleted;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
            
        }
    }
}

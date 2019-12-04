using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            try
            {
                _webshopContext._Invoices.Add(t);
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
            
           
        }

        public Invoice FindById(int? id)
        {
            try
            {
                return _webshopContext._Invoices.Find(id);
            }
            catch (Exception e)
            {
               
                throw new Exception(e.Message);
            }
           
        }

        public void Modify(Invoice invoice)
        {
            try
            {
                _webshopContext._Invoices.AddOrUpdate(invoice);
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
          
         
        }

        public List<Invoice> GetAll()
        {
            try
            {
                return _webshopContext._Invoices.ToList();
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
           
        }

        public void Remove(Invoice t)
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

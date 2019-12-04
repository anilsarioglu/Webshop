using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class ProductRepo : IRepository<Product>
    {
        private WebshopContext _webshopContext;
        public ProductRepo(WebshopContext context)
        {
            _webshopContext = context;
        }

        public Products Add(Product t)
        {
            try
            {
                _webshopContext._Products.Add(t);
                return t;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
            
         
        }

        public Product FindById(int? id)
        {
            try
            {
                return _webshopContext._Products.Find(id);
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public Product Modify(Product product)
        {
            try
            {
                _webshopContext._Products.AddOrUpdate();
                return t;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
           
        }

        public List<Product> GetAll()
        {
            return _webshopContext._Products.ToList();
        }

        public void Remove(Product t)
        {
            try
            {
                _webshopContext.Entry(t).State = EntityState.Deleted;
            }
            catch (Exception e)
            {
                
                throw new  Exception(e.Message);
            }

        }
    }
}

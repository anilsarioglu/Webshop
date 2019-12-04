using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class ProductPriceRepo : IRepository<ProductPrice>
    {
        private WebshopContext _webshopContext;

        public ProductPriceRepo(WebshopContext context)
        {
            _webshopContext = context;
        }

        public void Add(ProductPrice t)
        {
            try
            {
                _webshopContext._ProductPrices.Add(t);
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
            
            
        }

        public ProductPrice FindById(int? id)
        {
            try
            {
                return _webshopContext._ProductPrices.Find(id);
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
            
        }

        public void Modify(ProductPrice productPrice)
        {
            try
            {
                _webshopContext._ProductPrices.AddOrUpdate(productPrice);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public List<ProductPrice> GetAll()
        {
            try
            {
                return _webshopContext._ProductPrices.ToList();
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public void Remove(ProductPrice t)
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

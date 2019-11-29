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
            _webshopContext._ProductPrices.Add(t);
            
        }

        public ProductPrice FindById(int? id)
        {
            return _webshopContext._ProductPrices.Find(id);
        }

        public void Modify(ProductPrice productPrice)
        {
            _webshopContext._ProductPrices.AddOrUpdate(productPrice);
            
        }

        public List<ProductPrice> GetAll()
        {
            return _webshopContext._ProductPrices.ToList();
        }

        public void Remove(ProductPrice t)
        {
            _webshopContext.Entry(t).State = EntityState.Deleted;
          
        }
    }
}

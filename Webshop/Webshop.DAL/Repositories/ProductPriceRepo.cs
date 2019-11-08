using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class ProductPriceRepo : IRepository<ProductPrice>
    {
        private WebshopContext  _webshopContext = new WebshopContext();

        public void Create(ProductPrice t)
        {
            _webshopContext._ProductPrices.Add(t);
            _webshopContext.SaveChanges();
        }

        public ProductPrice Read(int? id)
        {
            return _webshopContext._ProductPrices.Find(id);
        }

        public void Update()
        {
            _webshopContext._ProductPrices.AddOrUpdate();
            _webshopContext.SaveChanges();
        }

        public List<ProductPrice> ReadAll()
        {
            return _webshopContext._ProductPrices.ToList();
        }

        public void Delete(ProductPrice t)
        {
            _webshopContext._ProductPrices.Remove(t);
            _webshopContext.SaveChanges();
        }
    }
}

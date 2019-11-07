using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class ProductPriceRepo : IRepository<ProductPrice>
    {
        private WebshopContext  _webshopContext = new WebshopContext();

        public void Add(ProductPrice t)
        {
            _webshopContext._ProductPrices.Add(t);
            _webshopContext.SaveChanges();
        }

        public ProductPrice FinById(int? id)
        {
            return _webshopContext._ProductPrices.Find(id);
        }

        public void Modify()
        {
            _webshopContext._ProductPrices.AddOrUpdate();
            _webshopContext.SaveChanges();
        }

        public List<ProductPrice> GetAll()
        {
            return _webshopContext._ProductPrices.ToList();
        }

        public void Remove(ProductPrice t)
        {
            _webshopContext._ProductPrices.Remove(t);
            _webshopContext.SaveChanges();
        }
    }
}

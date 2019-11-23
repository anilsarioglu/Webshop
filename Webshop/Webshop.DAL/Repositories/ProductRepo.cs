using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class ProductRepo : IRepository<Product>
    {
        private WebshopContext _webshopContext = new WebshopContext();

        public void Add(Product t)
        {
            _webshopContext._Products.Add(t);
            _webshopContext.SaveChanges();
        }

        public Product FindById(int? id)
        {
            return _webshopContext._Products.Find(id);
        }

        public void Modify(Product product)
        {
            _webshopContext._Products.AddOrUpdate();
            _webshopContext.SaveChanges();
        }

        public List<Product> GetAll()
        {
            foreach (Product product in DataHolder.GetProducts())
            {
                _webshopContext._Products.Add(product);
            }
            _webshopContext.SaveChanges();
            return _webshopContext._Products.ToList();
        }

        public void Remove(Product t)
        {
            _webshopContext._Products.Remove(t);
            _webshopContext.SaveChanges();
        }
    }
}

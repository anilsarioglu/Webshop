using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class ProductRepo : IRepository<Product>
    {
        private WebshopContext _webshopContext = new WebshopContext();

        public void Create(Product t)
        {
            _webshopContext._Products.Add(t);
            _webshopContext.SaveChanges();
        }

        public Product Read(int? id)
        {
            return _webshopContext._Products.Find(id);
        }

        public void Update()
        {
            _webshopContext._Products.AddOrUpdate();
            _webshopContext.SaveChanges();
        }

        public List<Product> ReadAll()
        {
            return _webshopContext._Products.ToList();
        }

        public void Delete(Product t)
        {
            _webshopContext._Products.Remove(t);
            _webshopContext.SaveChanges();
        }
    }
}

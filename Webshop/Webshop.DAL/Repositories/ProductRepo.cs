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

        public void Add(Product t)
        {
            _webshopContext._Products.Add(t);
         
        }

        public Product FindById(int? id)
        {
            return _webshopContext._Products.Find(id);
        }

        public void Modify(Product product)
        {
            _webshopContext._Products.AddOrUpdate();
           
        }

        public List<Product> GetAll()
        {
            return _webshopContext._Products.ToList();
        }

        public void Remove(Product t)
        {
            _webshopContext.Entry(t).State = EntityState.Deleted;

        }
    }
}

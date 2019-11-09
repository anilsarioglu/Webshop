using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.BL;
using Webshop.DAL.Entit;

namespace Webshop.SL.Controllers
{
    public class ProductController : ApiController
    {
        private List<Product> SeedList()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Video", 120, DateTime.Now, DateTime.Now, null, null, null));
            products.Add(new Product("Book", 40, DateTime.Now, DateTime.Now, null, null, null));
            products.Add(new Product("CD", 80, DateTime.Now, DateTime.Now, null, null, null));
            return products;
        }

        public IEnumerable<Product> Get()
        {
            
            return SeedList();
        }

        public Product Get(int id)
        {
            return SeedList().ElementAt(id - 1);
        }
    }
}

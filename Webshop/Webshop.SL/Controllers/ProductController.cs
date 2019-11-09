using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.BL;
using Webshop.DAL;
using Webshop.DAL.Entit;

namespace Webshop.SL.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            
            return DataHolder.GetProducts();
        }

        public Product Get(int id)
        {
            return DataHolder.GetProducts().ElementAt(id - 1);
        }
    }
}

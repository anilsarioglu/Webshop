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
        private ProductManager mgr = new ProductManager();

        public IEnumerable<Product> Get()
        {
            return mgr.GetAll();
        }

        public Product Get(int id)
        {
            return mgr.FindById(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.BL;
using Webshop.Domain;

namespace Webshop.SL.Controllers
{
    public class ProductController : ApiController
    {
        private ProductLogic productLogic = new ProductLogic();

        public IEnumerable<ProductDTO> Get()
        {
            return productLogic.GetAll().AsEnumerable();
        }

        public string Get(int id)
        {
            return "test " + id;
        }
    }
}

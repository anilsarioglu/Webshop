using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.DAL;
using Webshop.DAL.Entit;

namespace Webshop.SL.Controllers
{
    public class ProductPriceController : ApiController
    {
        public IEnumerable<ProductPrice> Get()
        {

            return DataHolder.GetProductPrices();
        }

        public ProductPrice Get(int id)
        {
            return DataHolder.GetProductPrices().ElementAt(id - 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.BL;

namespace Webshop.SL.Controllers
{
    public class ProductController : ApiController
    {

        public string Get()
        {
            return "test";
        }

        public string Get(int id)
        {
            return "test " + id;
        }
    }
}

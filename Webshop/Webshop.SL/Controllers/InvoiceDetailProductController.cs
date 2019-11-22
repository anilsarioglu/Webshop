using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.Domain;
using Webshop.BL;

namespace Webshop.SL.Controllers
{
    public class InvoiceDetailProductController : ApiController
    {
        private InvoiceDetailLogic invoiceDetailLogic = new InvoiceDetailLogic();

        public IEnumerable<InvoiceDetailDTO> Get()
        {
            return invoiceDetailLogic.GetAll().AsEnumerable();
        }

        public string Get(int id)
        {
            return "test " + id;
        }
    }
}

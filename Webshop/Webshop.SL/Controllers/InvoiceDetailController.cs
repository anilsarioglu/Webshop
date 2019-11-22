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
    public class InvoiceDetailController : ApiController
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

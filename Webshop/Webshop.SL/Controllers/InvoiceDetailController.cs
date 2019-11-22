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
    public class InvoiceDetailController : ApiController
    {
        private InvoiceDetailLogic invoiceDetailLogic = new InvoiceDetailLogic();

        public IEnumerable<InvoiceDetailDTO> Get()
        {
            return invoiceDetailLogic.GetAll().AsEnumerable();
        }

        public InvoiceDetailDTO Get(int id)
        {
            return invoiceDetailLogic.FindByID(id);
        }

        public void Create(InvoiceDetailDTO c)
        {
            invoiceDetailLogic.Create(c);
        }

        public void Update(InvoiceDetailDTO c)
        {
            invoiceDetailLogic.Update(c);
        }

        public void Delete(InvoiceDetailDTO c)
        {
            invoiceDetailLogic.Delete(c);
        }
    }
}

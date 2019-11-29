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
    public class InvoiceController : ApiController
    {
        public ILogic<InvoiceDTO> invoiceLogic;
        
        public InvoiceController(InvoiceLogic logic)
        {
            invoiceLogic = logic;
        }


        public void Create(InvoiceDTO invoiceDTO)
        {
          invoiceLogic.Create(invoiceDTO);
        }

        public IEnumerable<InvoiceDTO> GetInvoices()
        {

            return invoiceLogic.GetAll().AsEnumerable();
        }

        public InvoiceDTO Get(int id)
        {
          return invoiceLogic.FindByID(id);
        }

        [HttpDelete]
        public void Delete(InvoiceDTO invoiceDTO)
        {
          invoiceLogic.Delete(invoiceDTO);
        }

        [HttpPut]
        public void Update(InvoiceDTO invoiceDTO)
        {
           invoiceLogic.Update(invoiceDTO);
        }
  }
}

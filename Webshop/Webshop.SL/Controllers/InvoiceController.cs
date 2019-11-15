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
        public InvoiceLogic invoiceLogic;

        public InvoiceController()
        {
            invoiceLogic = new InvoiceLogic();
        }

        public List<InvoiceDTO> GetInvoices()
        {
            //als je testdata van invoice in u database wilt
            //repo.insertData();
            return invoiceLogic.GetAll();
        }
    }
}
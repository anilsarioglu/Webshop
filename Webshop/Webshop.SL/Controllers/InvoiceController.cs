using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.BL;
using Webshop.DAL.Repositories;
using Webshop.Domain;

namespace Webshop.SL.Controllers
{
    public class InvoiceController : ApiController
    {
        public InvoiceLogic invoiceLogic;
        public InvoiceRepo repo;

        public InvoiceController()
        {
            repo = new InvoiceRepo();
            invoiceLogic = new InvoiceLogic();
        }

        public List<InvoiceDTO> GetInvoices()
        {
            repo.insertData();
            return invoiceLogic.GetAll();
        }
    }
}
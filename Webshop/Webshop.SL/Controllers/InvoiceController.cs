using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.BL;
using Webshop.DAL;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;

namespace Webshop.SL.Controllers
{

    public class InvoiceController : ApiController
    {
    public InvoiceManager invoiceLogic;
    public InvoiceController()
    {
      invoiceLogic = new InvoiceManager();
    }
    public IEnumerable<Invoice> GetInvoices()
    {
      //als je testdata van invoice in u database wilt
      //repo.insertData();
      return invoiceLogic.GetAll();
     
    }
    }
}

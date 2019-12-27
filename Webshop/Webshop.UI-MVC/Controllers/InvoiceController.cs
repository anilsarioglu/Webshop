using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.UI_MVC.Models.Webshop;

namespace Webshop.UI_MVC.Controllers
{
    public class InvoiceController : Controller
    {
        private const string PATH = "invoice";
        private IEnumerable<Invoice> invoices = APIConsumer<Invoice>.GetAPI("invoice");
        private List<Invoice> activeInvoices = new List<Invoice>();
        private List<Invoice> deletedInvoices = new List<Invoice>();

        // GET: Invoice
        public ActionResult Index()
        {
            foreach (Invoice item in invoices)
            {
                if (item.Deleted == false)
                {
                    activeInvoices.Add(item);
                }
            }
            return View(activeInvoices);
        }

        public ActionResult DeletedIndex()
        {
            foreach (Invoice item in invoices)
            {
                if (item.Deleted == true)
                {
                    deletedInvoices.Add(item);
                }
            }
            return View(deletedInvoices);
        }

        // GET: Invoice/Details/5
        public ActionResult Details(int id)
        {
            return View(APIConsumer<Invoice>.GetObject(PATH , id.ToString()));
        }

        // GET: Invoice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Invoice/Create
        [HttpPost]
        public ActionResult Create(Invoice invoice)
        {
            try
            {
                // TODO: Add insert logic here
                APIConsumer<Models.Webshop.Invoice>.AddObject(PATH, invoice);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Invoice/Edit/5
        public ActionResult Edit(int id)
        {
            Invoice invoice = APIConsumer<Invoice>.GetObject(PATH, id.ToString());
            if (invoice.Deleted == false)
            {
                return View(invoice);
            }
            else return RedirectToAction("DeletedIndex");
        }

        // POST: Invoice/Edit/5
        [HttpPost]
        public ActionResult Edit(Invoice invoice)
        {
            try
            {
                // TODO: Add update logic here
                APIConsumer<Models.Webshop.Invoice>.EditObject(PATH, invoice.Id.ToString(), invoice);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Invoice/Delete/5
        public ActionResult Delete(int id)
        {
            Invoice invoice = APIConsumer<Invoice>.GetObject(PATH, id.ToString());
            if (invoice.Deleted == false)
            {
                return View(invoice);
            }
            else return RedirectToAction("DeletedIndex");
        }

        // POST: Invoice/Delete/5
        [HttpPost]
        public ActionResult Delete(Invoice invoice)
        {
            try
            {
                // TODO: Add delete logic here
                invoice = APIConsumer<Invoice>.GetObject(PATH, (invoice.Id).ToString());
                invoice.Deleted = true;
                APIConsumer<Models.Webshop.Invoice>.EditObject(PATH, invoice.Id.ToString(), invoice);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

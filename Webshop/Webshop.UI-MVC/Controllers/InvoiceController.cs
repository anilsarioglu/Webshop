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

        // GET: Invoice
        public ActionResult Index()
        {
            return View(invoices);
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
            return View(APIConsumer<Invoice>.GetObject(PATH, id.ToString()));
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
            return View(APIConsumer<Invoice>.GetObject(PATH, id.ToString()));
        }

        // POST: Invoice/Delete/5
        [HttpPost]
        public ActionResult Delete(Invoice invoice)
        {
            try
            {
                // TODO: Add delete logic here
                APIConsumer<Models.Webshop.Invoice>.DeleteObject(PATH, (invoice.Id).ToString(), invoice);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

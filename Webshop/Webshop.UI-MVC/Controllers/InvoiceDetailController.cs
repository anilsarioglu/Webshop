using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.UI_MVC.Models.Webshop;

namespace Webshop.UI_MVC.Controllers
{
    public class InvoiceDetailController : Controller
    {
        private IEnumerable<InvoiceDetail> invoiceDetails = APIConsumer<InvoiceDetail>.GetAPI("invoicedetail");

        // GET: InvoiceDetail
        public ActionResult Index()
        {
            return View(invoiceDetails);
        }

        // GET: InvoiceDetail/Details/5
        public ActionResult Details(int id)
        {
            return View(invoiceDetails.ElementAt(id + 1));
        }

        // GET: InvoiceDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvoiceDetail/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceDetail/Edit/5
        public ActionResult Edit(int id)
        {
            return View(invoiceDetails.ElementAt(id + 1));
        }

        // POST: InvoiceDetail/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceDetail/Delete/5
        public ActionResult Delete(int id)
        {
            return View(invoiceDetails.ElementAt(id + 1));
        }

        // POST: InvoiceDetail/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.DAL.Entit;

namespace Webshop.UI_MVC.Controllers
{
    public class InvoiceDetailProductController : Controller
    {
        private IEnumerable<InvoiceDetailProduct> invoiceDetailProducts = APIConsumer<InvoiceDetailProduct>.GetAPI("invoicedetailproduct");

        // GET: InvoiceDetailProduct
        public ActionResult Index()
        {
            return View(invoiceDetailProducts);
        }

        // GET: InvoiceDetailProduct/Details/5
        public ActionResult Details(int id)
        {
            return View(invoiceDetailProducts.ElementAt(id + 1));
        }

        // GET: InvoiceDetailProduct/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvoiceDetailProduct/Create
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

        // GET: InvoiceDetailProduct/Edit/5
        public ActionResult Edit(int id)
        {
            return View(invoiceDetailProducts.ElementAt(id + 1));
        }

        // POST: InvoiceDetailProduct/Edit/5
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

        // GET: InvoiceDetailProduct/Delete/5
        public ActionResult Delete(int id)
        {
            return View(invoiceDetailProducts.ElementAt(id + 1));
        }

        // POST: InvoiceDetailProduct/Delete/5
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

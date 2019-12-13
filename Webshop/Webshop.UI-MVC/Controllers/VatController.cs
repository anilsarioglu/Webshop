using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.UI_MVC.Models.Webshop;

namespace Webshop.UI_MVC.Controllers
{
    public class VatController : Controller
    {
        private IEnumerable<Vat> vats = APIConsumer<Vat>.GetAPI("vat");

        // GET: Vat
        public ActionResult Index()
        {
            return View(vats);
        }

        // GET: Vat/Details/5
        public ActionResult Details(int id)
        {
            return View(vats.ElementAt(id + 1));
        }

        // GET: Vat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vat/Create
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

        // GET: Vat/Edit/5
        public ActionResult Edit(int id)
        {
            return View(vats.ElementAt(id + 1));
        }

        // POST: Vat/Edit/5
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

        // GET: Vat/Delete/5
        public ActionResult Delete(int id)
        {
            return View(vats.ElementAt(id + 1));
        }

        // POST: Vat/Delete/5
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

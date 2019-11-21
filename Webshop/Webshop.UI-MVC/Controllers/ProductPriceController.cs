using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.DAL.Entit;
using Webshop.Domain;

namespace Webshop.UI_MVC.Controllers
{
    public class ProductPriceController : Controller
    {
        private IEnumerable<ProductPriceDTO> productPrices = APIConsumer<ProductPriceDTO>.GetAPI("productprice");
        // GET: ProductPrice
        public ActionResult Index()
        {
            return View(productPrices);
        }

        // GET: ProductPrice/Details/5
        public ActionResult Details(int id)
        {
            return View(productPrices.ElementAt(id + 1));
        }

        // GET: ProductPrice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductPrice/Create
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

        // GET: ProductPrice/Edit/5
        public ActionResult Edit(int id)
        {
            return View(productPrices.ElementAt(id + 1));
        }

        // POST: ProductPrice/Edit/5
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

        // GET: ProductPrice/Delete/5
        public ActionResult Delete(int id)
        {
            return View(productPrices.ElementAt(id + 1));
        }

        // POST: ProductPrice/Delete/5
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

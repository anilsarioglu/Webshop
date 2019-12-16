using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Webshop.UI_MVC.Models.Webshop;

namespace Webshop.UI_MVC.Controllers
{
    public class ProductController : Controller
    {
        private const string PATH = "product";
        IEnumerable<Product> products = APIConsumer<Product>.GetAPI("product");

        // GET: Product
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: Product/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int id)
        {
            return View(APIConsumer<Product>.GetObject(PATH, id.ToString()));
        }

        // GET: Product/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                APIConsumer<Models.Webshop.Product>.AddObject(PATH, product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            return View(APIConsumer<Product>.GetObject(PATH, id.ToString()));
        }

        // POST: Product/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Product product)
        {
            try
            {
                // TODO: Add update logic here
                APIConsumer<Models.Webshop.Product>.EditObject(PATH, product.Id.ToString(), product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            return View(APIConsumer<Product>.GetObject(PATH, id.ToString()));
        }

        // POST: Product/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Product product)
        {
       try
            {
                // TODO: Add delete logic here
                APIConsumer<Models.Webshop.Product>.DeleteObject(PATH, (product.Id).ToString(), product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

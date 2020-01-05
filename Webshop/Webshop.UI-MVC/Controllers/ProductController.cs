using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Webshop.UI_MVC.Models.Webshop;
using PagedList;

namespace Webshop.UI_MVC.Controllers
{
    public class ProductController : Controller
    {
        private const string PATH = "product";
        IEnumerable<Product> products = APIConsumer<Product>.GetAPI("product");

        // GET: Product
        public ActionResult Index(string searchString, string currentFilter,int ? page)
        {

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                var result = products.Where(s => s.Name.ToLower().Contains(searchString) || s.Name.Contains(searchString)
                                 || s.StartDate.ToString().Contains(searchString)
                                 || s.EndDate.ToString().Contains(searchString));
                return View(result);
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);

            return View(products.ToPagedList(pageNumber,pageSize));
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
            if (product.EndDate < product.StartDate)
            {
                ModelState.AddModelError("EndDate", "Einddatum moet groter dan startdatum zijn");
            }
            else if (product.StartDate < DateTime.Today)
            {
                ModelState.AddModelError("StartDate", "Startdatum moet groter of gelijk zijn dan vandaag");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ProductPrice productPrice = new ProductPrice(product.Price, product.StartDate, product.EndDate);
                    APIConsumer<ProductPrice>.AddObject("productprice", productPrice);
                    APIConsumer<Models.Webshop.Product>.AddObject(PATH, product);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            return View();
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
            if (product.EndDate < product.StartDate)
            {
                ModelState.AddModelError("EndDate", "Einddatum moet groter dan startdatum zijn");
            }
            else if (product.StartDate < DateTime.Today)
            {
                ModelState.AddModelError("StartDate", "Startdatum moet groter dan dag van vandaag zijn");
            }

            if (ModelState.IsValid)
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

            return View();
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
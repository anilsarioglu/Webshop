using System.Collections.Generic;
using System.Web.Mvc;
using Webshop.UI_MVC.Models.Webshop;

namespace Webshop.UI_MVC.Controllers
{
    public class ProductReportController : Controller
    {
        IEnumerable<Product> products = APIConsumer<Product>.GetAPI("product");

        // GET: ProductReport
        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Details(int id)
        {
            return RedirectToAction("Details", "Product", new {id});
        }
    }
}
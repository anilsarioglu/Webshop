using System.Collections.Generic;
using System.Web.Mvc;
using Webshop.UI_MVC.Models.Webshop;

namespace Webshop.UI_MVC.Controllers
{
    public class ProductReportController : Controller
    {
        private const string PATH = "product";
        IEnumerable<Product> products = APIConsumer<Product>.GetAPI(PATH);

        // GET: ProductReport
        public ActionResult Index()
        {
            return View(products);
        }
    }
}
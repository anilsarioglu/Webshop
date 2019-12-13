using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.Domain;
using Webshop.UI_MVC.Models.Webshop;

namespace Webshop.UI_MVC.Controllers
{
    public class ShoppinCartController : Controller
    {
        // GET: ShoppinCart
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Buy(int id)
        {
            Product productModel = new Product();

            if (Session["cart"] == null)
            {
                IEnumerable<Course> course = APIConsumer<Course>.GetAPI("course");
                List<Course> courses = course.ToList();
                courses.Add(courses.ElementAt(id));
                Session["cart"] = courses;
            }
            else
            { 
                List<Course> courses = (List<Course>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    courses[index].InvoiceDetail.Pieces++;
                }
                else
                {
                    courses.Add(courses.ElementAt(id));
                }
                Session["cart"] = courses;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            List<Course> cart = (List<Course>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }

        private int isExist(int id)
        {
            List<Course> cart = (List<Course>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.Id.Equals(id))
                    return i;
            return -1;
        }
    }
}
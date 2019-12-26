using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.UI_MVC.Models.Webshop;

namespace Webshop.UI_MVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppinCart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buy(int id)
        {
            Course courses = APIConsumer<Course>.GetObject("course", id.ToString());

            if (courses != null)
            {
                if (Session["cart"] == null)
                {
                    List<ShoppingCart> cart = new List<ShoppingCart>();
                    cart.Add(new ShoppingCart() {Course = courses, Quantity = 1});
                    Session["cart"] = cart;
                    Session["count"] = 1;
                }
                else
                {
                    List<ShoppingCart> cart = (List<ShoppingCart>) Session["cart"];

                    int index = CourseExists(id);
                    if (index != -1)
                    {
                        cart[index].Quantity++;
                        Session["count"] = Convert.ToInt32(Session["count"]) + 1;
                    }
                    else
                    {
                        cart.Add(new ShoppingCart() {Course = courses, Quantity = 1});
                        Session["count"] = Convert.ToInt32(Session["count"]) + 1;
                    }

                    Session["card"] = cart;
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult BuyProduct(int id)
        {
            Product products = APIConsumer<Product>.GetObject("product", id.ToString());

            if (products != null)
            {
                if (Session["cart"] == null)
                {
                    List<ShoppingCart> cart = new List<ShoppingCart>();
                    cart.Add(new ShoppingCart() {Product = products, Quantity = 1});
                    Session["cart"] = cart;
                    Session["count"] = 1;
                }
                else
                {
                    List<ShoppingCart> cart = (List<ShoppingCart>) Session["cart"];

                    int index = ProductExists(id);
                    if (index != -1)
                    {
                        cart[index].Quantity++;
                        Session["count"] = Convert.ToInt32(Session["count"]) + 1;
                    }
                    else
                    {
                        cart.Add(new ShoppingCart() {Product = products, Quantity = 1});
                        Session["count"] = Convert.ToInt32(Session["count"]) + 1;
                    }

                    Session["card"] = cart;
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult RemoveQuantity(int id)
        {
            List<ShoppingCart> cart = (List<ShoppingCart>) Session["cart"];
            int index = CourseExists(id);
            if (cart[index].Quantity > 1)
            {
                cart[index].Quantity--;
                Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            }
            else
            {
                cart.RemoveAt(index);
                Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            }

            Session["cart"] = cart;

            if (cart.Count == 0)
            {
                Session.Clear();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            List<ShoppingCart> cart = (List<ShoppingCart>) Session["cart"];
            int index = CourseExists(id);
            Session["cart"] = cart;

            if (index != -1)
            {
                int aantal = cart[index].Quantity;
                Session["count"] = Convert.ToInt32(Session["count"]) - aantal;
            }

            cart.RemoveAt(index);

            if (cart.Count == 0)
            {
                Session["count"] = 0;
                Session.Clear();
            }

            return RedirectToAction("Index");
        }

        private int CourseExists(int? id)
        {
            List<ShoppingCart> cart = (List<ShoppingCart>) Session["cart"];

            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Course.Id.Equals(id))
                    return i;
            return -1;
        }

        private int ProductExists(int? id)
        {
            List<ShoppingCart> cart = (List<ShoppingCart>)Session["cart"];

            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.Id.Equals(id))
                    return i;
            return -1;
        }
    }
}
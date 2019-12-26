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
            IEnumerable<Product> products = APIConsumer<Product>.GetAPI("product");
            Product product = APIConsumer<Product>.GetObject("product", id.ToString());
            List<Product> products1 = products.ToList();
            Product product2 = products1.Where(i => i.StartDate == product.StartDate && i.Id == product.Id).First();
            

            if (courses != null)
            {
                if (Session["cart"] == null)
                {
//                    List<ShoppingCard> cart = Session["cart"];
                    List<ShoppingCart> cart = new List<ShoppingCart>();
                    cart.Add(new ShoppingCart() {Course = courses, Product = product2
                        ,Quantity = 1});
                    Session["cart"] = cart;
                    Session["count"] = 1;
                }
                else
                {
                    List<ShoppingCart> cart = (List<ShoppingCart>) Session["cart"];

                    int index = ItemExists(id);
                    if (index != -1)
                    {
                        cart[index].Quantity++;
                        Session["count"] = Convert.ToInt32(Session["count"]) + 1;
                    }
                    else
                    {

                        cart.Add(new ShoppingCart() { Course = courses, Product = product2,Quantity = 1});
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
            int index = ItemExists(id);
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

            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            List<ShoppingCart> cart = (List<ShoppingCart>) Session["cart"];
            int index = ItemExists(id);
            Session["cart"] = cart;
            //int counter = Convert.ToInt32(Session["count"]);
            //Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            
            if (index != -1)
            {
                int aantal = cart[index].Quantity;
                Session["count"] = Convert.ToInt32(Session["count"]) - aantal;
            }
            else if (cart.Count == 0)
            {
                Session["count"] = 0;
            }

            cart.RemoveAt(index);
            return RedirectToAction("Index");
        }

        private int ItemExists(int? id)
        {
            List<ShoppingCart> cart = (List<ShoppingCart>) Session["cart"];

            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Course.Id.Equals(id))
                {
                    return i;
                }
                else if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }

            return -1;
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            Course courses = APIConsumer<Course>.GetObject("course", id.ToString());
          
            
            if (courses != null)
            {
                if (Session["cart"] == null)
                {
//                    List<ShoppingCard> cart = Session["cart"];
                    List<ShoppingCard> cart = new List<ShoppingCard>();
                    cart.Add(new ShoppingCard() {Course = courses, Quantity = 1});
                    Session["cart"] = cart;
                }
                else
                {
                    List<ShoppingCard> cart = (List<ShoppingCard>) Session["cart"];

                    int index = ItemExists(id);
                    if (index != -1)
                    {
                        cart[index].Quantity++;
                    }
                    else
                    {
                        
                        cart.Add(new ShoppingCard() {Course = courses, Quantity = 1});
                    }

                    Session["card"] = cart;
                }
            }
            return RedirectToAction("Index");

        }

        public ActionResult Remove(int id)
        {
            List<Course> cart = (List<Course>)Session["cart"];
            int index = ItemExists(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }
        private int ItemExists(int? id)
        {
            List<ShoppingCard> cart = (List<ShoppingCard>)Session["cart"];

            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Course.Id.Equals(id))
                    return i;
            return -1;
        }

    }
}
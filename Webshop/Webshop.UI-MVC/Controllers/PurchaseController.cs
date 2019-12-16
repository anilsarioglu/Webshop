using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Syncfusion.Pdf.Grid;
using Webshop.UI_MVC.Models;
using Webshop.UI_MVC.Models.Webshop;

namespace Webshop.UI_MVC.Controllers
{
    public class PurchaseController : Controller
    {
        // GET: Purchase
        public ActionResult Index()
        {
            bool loggedIn = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (loggedIn == true)
            {
                return View();
            }
            else return RedirectToAction("Login", "Account");
        }


        //POST: Purchase
        [HttpPost]
        public ActionResult Index(List<ShoppingCart> cart)
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext()
                .GetUserManager<ApplicationUserManager>()
                .FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());

            Webshop.BL.EmailService service = new Webshop.BL.EmailService();
            PdfDocument doc = new PdfDocument();
            //Add a page
            PdfPage page = doc.Pages.Add();
            //Create a PdfGrid
            PdfGrid pdfGrid = new PdfGrid();
            PdfGrid pdfGrid2 = new PdfGrid();

            //Create a DataTable
            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();

            //Add columns to the DataTable
            dataTable.Columns.Add("Product");
            dataTable.Columns.Add("Aantal");
            dataTable.Columns.Add("Prijs");
            //Add rows to the DataTable
            cart = (List<ShoppingCart>)Session["cart"];
            foreach (ShoppingCart item in (List<ShoppingCart>) Session["cart"])
            {
                dataTable.Rows.Add(new object[] { item.Course.Name, item.Quantity, (item.Course.Price * item.Quantity) });
            }

            dataTable2.Columns.Add("Totaal");
            dataTable2.Rows.Add(new object[] { cart.Sum(item => item.Course.Price * item.Quantity) });

            //Assign data source
            pdfGrid.DataSource = dataTable;
            pdfGrid2.DataSource = dataTable2;
            //Draw grid to the page of PDF document
            PdfLayoutResult articles =  pdfGrid.Draw(page, new PointF(10, 200));
            pdfGrid2.Draw(articles.Page, new PointF(10, articles.Bounds.Bottom + 5));
            //Save the document
            doc.Save(@"\Invoices\Output.pdf");
            //Close the document
            doc.Close(true);

            //TODO CUSTOMER MAIL AND PERSONAL INFO ON INVOICE
            string mail = user.Email;
            //string email = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            service.SendInvoice(mail, "factuur", "Als bijlage je bestelbon.");
            return Index();
        }
    }
}
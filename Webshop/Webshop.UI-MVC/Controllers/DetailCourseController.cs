using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.DAL.Entit;

namespace Webshop.UI_MVC.Controllers
{
    public class DetailCourseController : Controller
    {
        private IEnumerable<DetailCourse> detailCourses = APIConsumer<DetailCourse>.GetAPI("detailcourse");

        // GET: DetailCourse
        public ActionResult Index()
        {
            return View(detailCourses);
        }

        // GET: DetailCourse/Details/5
        public ActionResult Details(int id)
        {
            return View(detailCourses.ElementAt(id + 1));
        }

        // GET: DetailCourse/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetailCourse/Create
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

        // GET: DetailCourse/Edit/5
        public ActionResult Edit(int id)
        {
            return View(detailCourses.ElementAt(id + 1));
        }

        // POST: DetailCourse/Edit/5
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

        // GET: DetailCourse/Delete/5
        public ActionResult Delete(int id)
        {
            return View(detailCourses.ElementAt(id + 1));
        }

        // POST: DetailCourse/Delete/5
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

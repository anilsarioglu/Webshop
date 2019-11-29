using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.Domain;
using Webshop.UI_MVC.Models.Webshop;

namespace Webshop.UI_MVC.Controllers
{
    public class CourseController : Controller
    {
        private IEnumerable<Course> courses = APIConsumer<Course>.GetAPI("course");

        // GET: Course
        public ActionResult Index()
        {
            return View(courses);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View(courses.ElementAt(id - 1));
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            try
            {
        // TODO: Add insert logic here
        APIConsumer<Models.Webshop.Course>.AddObject<Models.Webshop.Course>("course", course);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View(courses.ElementAt(id - 1));
        }

        // POST: Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Course course)
        {
            try
            {
        // TODO: Add update logic here
        APIConsumer<Models.Webshop.Course>.EditObject<Models.Webshop.Course>("course" , course.Id.ToString(), course);
        return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View(courses.ElementAt(id - 1));
        }

        // POST: Course/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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

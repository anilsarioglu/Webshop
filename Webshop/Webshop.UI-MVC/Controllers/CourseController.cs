using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.Domain;

namespace Webshop.UI_MVC.Controllers
{
    public class CourseController : Controller
    {
        private IEnumerable<CourseDTO> courses = APIConsumer<CourseDTO>.GetAPI("course");

        // GET: Course
        public ActionResult Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var result = courses.Where(s => s.Name.ToLower().Contains(searchString) || s.Name.Contains(searchString)
                                                                                        || s.Price.ToString()
                                                                                            .Contains(searchString));
                return View(result);
            }
            return View(courses);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View(courses.ElementAt(id + 1));
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
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

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View(courses.ElementAt(id + 1));
        }

        // POST: Course/Edit/5
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

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View(courses.ElementAt(id + 1));
        }

        // POST: Course/Delete/5
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

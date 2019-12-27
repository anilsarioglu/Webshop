using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int id)
        {
            return View(APIConsumer<Course>.GetObject("course", id.ToString()));
        }

        // GET: Course/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Course course)
        {
            try
            {
        // TODO: Add insert logic here
                APIConsumer<Models.Webshop.Course>.AddObject("course", course);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            return View(APIConsumer<Course>.GetObject("course", id.ToString()));
        }

        // POST: Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Course course)
        {
            try
            {
        // TODO: Add update logic here
          APIConsumer<Models.Webshop.Course>.EditObject("course" , course.Id.ToString(), course);
          return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            return View(APIConsumer<Course>.GetObject("course" , id.ToString()));
        }

        // POST: Course/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Course course)
        {
            try
            {
        // TODO: Add delete logic here
            APIConsumer<Models.Webshop.Course>.DeleteObject("course", (course.Id).ToString() , course);
            return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

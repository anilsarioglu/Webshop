using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Webshop.BL;
using Webshop.DAL;
using Webshop.Domain;

namespace Webshop.UI_MVC.Controllers
{
    public class CourseDTOesController : Controller
    {
        private WebshopContext db = new WebshopContext();
        // GET: CourseDTOes
        public ActionResult Index()
        {
            return View(db.CourseDTOes.ToList());
        }

        // GET: CourseDTOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDTO courseDTO = db.CourseDTOes.Find(id);
            if (courseDTO == null)
            {
                return HttpNotFound();
            }
            return View(courseDTO);
        }

        // GET: CourseDTOes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseDTOes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,price")] CourseDTO courseDTO)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View(courseDTO);
        }

        // GET: CourseDTOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDTO courseDTO = db.CourseDTOes.Find(id);
            if (courseDTO == null)
            {
                return HttpNotFound();
            }
            return View(courseDTO);
        }

        // POST: CourseDTOes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,price")] CourseDTO courseDTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseDTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseDTO);
        }

        // GET: CourseDTOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDTO courseDTO = db.CourseDTOes.Find(id);
            if (courseDTO == null)
            {
                return HttpNotFound();
            }
            return View(courseDTO);
        }

        // POST: CourseDTOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseDTO courseDTO = db.CourseDTOes.Find(id);
            db.CourseDTOes.Remove(courseDTO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

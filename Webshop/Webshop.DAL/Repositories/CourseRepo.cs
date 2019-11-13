using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class CourseRepo : IRepository<Course>
    {
        private WebshopContext _webshopContext = new WebshopContext();
        public void Add(Course course)
        {
            _webshopContext._Courses.Add(course);
            _webshopContext.SaveChanges();
        }

        public Course FindById(int? id)
        {
            return _webshopContext._Courses.Find(id);
        }

        public void Modify(Course course)
        {
            _webshopContext._Courses.AddOrUpdate(course);
        }

        public List<Course> GetAll()
        {
            return _webshopContext._Courses.ToList();
        }

        public void Remove(Course t)
        {
            _webshopContext._Courses.Remove(t);
        }

       
    }
}

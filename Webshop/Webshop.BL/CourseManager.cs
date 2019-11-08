using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;

namespace Webshop.BL
{
    class CourseManager : IManager<Course>
    {
        private CourseRepo repo;

        public CourseManager()
        {
            repo = new CourseRepo();
        }

        public void Add(Course t)
        {
            repo.Add(t);
        }

        public Course FinById(int? id)
        {
            return repo.FindById(id);
        }

        public void Modify()
        {
            repo.Modify();
        }

        public List<Course> GetAll()
        {
            return repo.GetAll();
        }

        public void Remove(Course t)
        {
            repo.Remove(t);
        }
    }
}
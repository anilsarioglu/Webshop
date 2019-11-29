using System.Collections.Generic;
using AutoMapper;
using Webshop.DAL;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.DAL.UnitOfWork;
using Webshop.Domain;

namespace Webshop.BL
{
    public class CourseLogic : ILogic<CourseDTO>
    {
        private UnitOfWork _uow;

        public CourseLogic(UnitOfWork uow)
        {
            _uow = uow;
        }

        public void Create(CourseDTO c)
        {
            _uow.Courses.Add(MapDTO.Map<Course, CourseDTO>(c));
        }

        public CourseDTO FindByID(int? id)
        {
            Course c = _uow.Courses.FindById(id);

            return MapDTO.Map<CourseDTO, Course>(c);
        }

        public void Delete(CourseDTO c)
        {
            _uow.Courses.Remove(MapDTO.Map<Course, CourseDTO>(c));
        }

        public List<CourseDTO> GetAll()
        {
            return MapDTO.MapList<CourseDTO, Course>(_uow.Courses.GetAll());
        }

        public void Update(CourseDTO c)
        {
            _uow.Courses.Modify(MapDTO.Map<Course, CourseDTO>(c));
        }
    }
}

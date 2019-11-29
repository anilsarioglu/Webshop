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

        public CourseLogic()
        {
            _uow = new UnitOfWork();
        }


        public void Create(CourseDTO c)
        {
            _uow.CourseRepo.Add(MapDTO.Map<Course,CourseDTO>(c));
            _uow.Save();

        }

        public CourseDTO FindByID(int? id)
        {
            Course c = _uow.CourseRepo.FindById(id);

            return MapDTO.Map<CourseDTO,Course>(c);
        }

        public void Delete(CourseDTO c)
        {
            _uow.CourseRepo.Remove(MapDTO.Map<Course,CourseDTO>(c));
            _uow.Save();
        }

        public List<CourseDTO> GetAll()
        {
            return MapDTO.MapList<CourseDTO, Course>(_uow.CourseRepo.GetAll());
        }

        public void Update(CourseDTO c)
        {

            _uow.CourseRepo.Modify(MapDTO.Map<Course,CourseDTO>(c));
            _uow.Save();
            
        }
    }
}

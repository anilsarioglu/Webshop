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

        public static Course Map(CourseDTO e)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CourseDTO, Course>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            Course dto = mapper.Map<Course>(e);
            return dto;

        }
        public static CourseDTO Map(Course e)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, CourseDTO>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            CourseDTO dto = mapper.Map<CourseDTO>(e);
            return dto;

        }

        public void Create(CourseDTO c)
        {
            _uow.CourseRepo.Add(Map(c));
        }

        public CourseDTO FindByID(int? id)
        {
            Course c = _uow.CourseRepo.FindById(id);

            return Map(c);
        }

        public void Delete(CourseDTO c)
        {
            _uow.CourseRepo.Remove(Map(c));
        }

        public List<CourseDTO> GetAll()
        {
            List<Course> courses = _uow.CourseRepo.GetAll();
            List<CourseDTO> coursesDto = new List<CourseDTO>();

            foreach (Course c in courses)
            {
                coursesDto.Add(Map(c));
            }

            return coursesDto;
        }

        public void Update(CourseDTO c)
        {

            _uow.CourseRepo.Modify(Map(c));
            
        }
    }
}

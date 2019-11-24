using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Webshop.DAL;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.Domain;

namespace Webshop.BL
{
    public class CourseLogic : ILogic<CourseDTO>
    {
        private IRepository<Course> _courseRepo;

        public CourseLogic(CourseRepo repo)
        {
            _courseRepo = repo;
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
            _courseRepo.Add(Map(c));
        }

        public CourseDTO FindByID(int? id)
        {
            Course c = _courseRepo.FindById(id);

            return Map(c);
        }

        public void Delete(CourseDTO c)
        {
            _courseRepo.Remove(Map(c));
        }

        public List<CourseDTO> GetAll()
        {
            List<Course> courses = _courseRepo.GetAll();
            List<CourseDTO> coursesDto = new List<CourseDTO>();

            foreach (Course c in courses)
            {
                coursesDto.Add(Map(c));
            }

            return coursesDto;
        }

        public void Update(CourseDTO c)
        {

            _courseRepo.Modify(Map(c));
            
        }
    }
}

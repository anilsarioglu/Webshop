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

        public void Create(CourseDTO c)
        {
            _courseRepo.Add(MapDTO.Map<Course, CourseDTO>(c));
        }

        public CourseDTO FindByID(int? id)
        {
            Course c = _courseRepo.FindById(id);

            return MapDTO.Map<CourseDTO, Course>(c);
        }

        public void Delete(CourseDTO c)
        {
            _courseRepo.Remove(MapDTO.Map<Course, CourseDTO>(c));
        }

        public List<CourseDTO> GetAll()
        {
            List<Course> courses = _courseRepo.GetAll();
            List<CourseDTO> coursesDto = new List<CourseDTO>();

            foreach (Course c in courses)
            {
                coursesDto.Add(MapDTO.Map<CourseDTO, Course>(c));
            }

            return coursesDto;
        }

        public void Update(CourseDTO c)
        {

            _courseRepo.Modify(MapDTO.Map<Course, CourseDTO>(c));
            
        }
    }
}

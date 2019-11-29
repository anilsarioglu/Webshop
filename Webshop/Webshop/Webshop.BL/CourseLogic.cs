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
        private CourseRepo _courseRepo = new CourseRepo();
        private static readonly log4net.ILog log 
            = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
            try
            {
                _courseRepo.Add(Map(c));
                _courseRepo.Save();
            }
            catch (Exception e)
            {
                log.Error(" Cant add a course",e);
                throw new Exception("Cursus aanmaken failed");
            }
           
            _uow.Courses.Add(Map(c));
        }

        public CourseDTO FindByID(int? id)
        {
            try
            {
                Course c = _courseRepo.FindById(id);
                return Map(c);
            }
            catch (Exception e)
            {
                log.Error("Can't find ID", e);
                throw new Exception("niet gevonden cursus ");
            }
            Course c = _uow.Courses.FindById(id);

        }

        public void Delete(CourseDTO c)
        {
            try
            {
                _courseRepo.Remove(Map(c));
                _courseRepo.Save();
            }
            catch (Exception e)
            {
                log.Error("Remove Failed", e);
                throw new Exception("Verwijderen niet gelukt");
            }
            catch ()
            _uow.Courses.Remove(Map(c));
        }
            { }

    }

        public List<CourseDTO> GetAll()
        {
            List<Course> courses = _uow.Courses.GetAll();
            List<CourseDTO> coursesDto = new List<CourseDTO>();

                return coursesDto;
            }
            catch (Exception e)
            {
                log.Error("List FAILED");
                throw new Exception("Lijst ophalen niet gelukt");
            }
           
        }

        public void Update(CourseDTO c)
        {
            try
            {
                _courseRepo.Modify(Map(c));
                _courseRepo.Save();
            }
            catch (Exception e)
            {
                log.Error("Edit FAILED ",e);
                throw new Exception("Fout bij aanpassen");
            }

            _uow.Courses.Modify(Map(c));
            
        }
    }
}

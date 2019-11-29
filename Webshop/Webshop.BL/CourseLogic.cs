using System;
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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CourseLogic()
        {
            _uow = new UnitOfWork();
        }


        public void Create(CourseDTO c)
        {
            try
            {
                _uow.CourseRepo.Add(MapDTO.Map<Course, CourseDTO>(c));
                _uow.Save();
            }
            catch (Exception e)
            {
                log.Error("Kon geen cursus aanmaken",e);
                throw new  Exception(e.Message);
                
            }
           

        }

        public CourseDTO FindByID(int? id)
        {
            try
            {
                Course c = _uow.CourseRepo.FindById(id);

                return MapDTO.Map<CourseDTO, Course>(c);
            }
            catch (Exception e)
            {
                log.Error("Kon id niet vinden",e);
                throw new Exception(e.Message);
            }
            
        }

        public void Delete(CourseDTO c)
        {
            try
            {
                _uow.CourseRepo.Remove(MapDTO.Map<Course, CourseDTO>(c));
                _uow.Save();
            }
            catch (Exception e)
            {
                log.Error("kon geen cursus verwijderren",e);
                throw new Exception(e.Message);
            }
         
        }

        public List<CourseDTO> GetAll()
        {
            try
            {
                return MapDTO.MapList<CourseDTO, Course>(_uow.CourseRepo.GetAll());
            }
            catch (Exception e)
            {
                log.Error("kon niet ophalen",e);
                throw new Exception(e.Message);
            }
            
        }

        public void Update(CourseDTO c)
        {
            try
            {
                _uow.CourseRepo.Modify(MapDTO.Map<Course, CourseDTO>(c));
                _uow.Save();
            }
            catch (Exception e)
            {
                log.Error("kon niet updaten");
                throw new Exception(e.Message);
            }

            
        }
    }
}

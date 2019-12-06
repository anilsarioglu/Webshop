using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.BL;
using Webshop.Domain;

namespace Webshop.SL.Controllers
{
    public class CourseController : ApiController
    {
    public ILogic<CourseDTO> courseLogic;

    public CourseController(CourseLogic logic)
    {
      courseLogic = logic;
    }

    public IEnumerable<CourseDTO> GetInvoices()
    {

      return courseLogic.GetAll().AsEnumerable();
    }

    [HttpPost]
    public void Create(CourseDTO courseDTO)
    {
      courseLogic.Create(courseDTO);
    }
    public CourseDTO Get(int id)
    {
      return courseLogic.FindByID(id);
    }

    [HttpDelete]
    public void Delete(CourseDTO courseDTO)
    {
      courseLogic.Delete(courseDTO);
    }
    [HttpPut]
    public void Update(CourseDTO courseDTO)
    {
      courseLogic.Update(courseDTO);
    }
  }
}

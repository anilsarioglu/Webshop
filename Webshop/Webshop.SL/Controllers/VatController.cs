using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.BL;
using Webshop.Domain;

namespace Webshop.SL.Controller
{
    public class VatController : ApiController
    {
        private ILogic<VatDTO> _vatLogic;

        public VatController(VatLogic logic)
        {
            _vatLogic = logic;
        }

        public IEnumerable<VatDTO> Get()
        {
            return _vatLogic.GetAll().AsEnumerable();
        }

        public VatDTO GetById(int id)
        {
            return _vatLogic.FindByID(id);
        }

        [HttpPost]
        public void Create(VatDTO vatDto)
        {
            if (ModelState.IsValid)
            {
                _vatLogic.Create(vatDto);
            }

        }

        [HttpPut]
        public void Put(VatDTO vatDto)
        {
            _vatLogic.Update(vatDto);
        }

        [HttpDelete]
        public void Delete(VatDTO vatDto)
        {
            _vatLogic.Delete(vatDto);
        }
    }
}

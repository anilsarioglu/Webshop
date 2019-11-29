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
    public class ProductController : ApiController
    {
        private ILogic<ProductDTO> productLogic;

        public ProductController(ProductLogic logic)
        {
            productLogic = logic;
        }

        public IEnumerable<ProductDTO> Get()
        {
            return productLogic.GetAll().AsEnumerable();
        }

        public ProductDTO Get(int id)
        {
          return productLogic.FindByID(id);
        }

        [HttpDelete]
        public void Delete(ProductDTO productDTO)
        {
          productLogic.Delete(productDTO);
        }
        [HttpPut]
        public void Update(ProductDTO productDTO)
        {
          productLogic.Update(productDTO);
        }
        [HttpPost]
        public void Create(ProductDTO productDTO)
        {
          productLogic.Create(productDTO);
        }
  }
}

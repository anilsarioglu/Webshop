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
    public class ProductPriceController : ApiController
    {
        private ILogic<ProductPriceDTO> _productPriceLogic;

        public ProductPriceController(ProductPriceLogic logic)
        {
            _productPriceLogic = logic;
        }

        //GET /api/productprice
        public IEnumerable<ProductPriceDTO> Get()
        {
            return _productPriceLogic.GetAll().AsEnumerable();
        }

        //GET /api/productprice/1
        public ProductPriceDTO GetById(int id)
        {
            return _productPriceLogic.FindByID(id);
        }

        //POST /api/productprice
        [HttpPost]
        public void Add(ProductPriceDTO productPriceDto)
        {
            _productPriceLogic.Create(productPriceDto);
        }

        //PUT /api/productprice/1
        [HttpPut]
        public void Update(ProductPriceDTO productPriceDto)
        {
            _productPriceLogic.Update(productPriceDto);
        }

        //Delete /api/productprice/1
        [HttpDelete]
        public void Delete(ProductPriceDTO productPriceDto)
        {
            _productPriceLogic.Delete(productPriceDto);
        }
    }
}

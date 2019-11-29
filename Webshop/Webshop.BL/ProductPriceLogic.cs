using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Webshop.DAL;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.DAL.UnitOfWork;
using Webshop.Domain;

namespace Webshop.BL
{
    public class ProductPriceLogic : ILogic<ProductPriceDTO>
    {
        private UnitOfWork _uow;

        public ProductPriceLogic(UnitOfWork uow)
        {
            _uow = uow;
        }

        public ProductPriceDTO Create(ProductPriceDTO c)
        {
            _uow.ProductPrices.Add(MapDTO.Map<ProductPrice, ProductPriceDTO>(c));
            return c;
        }

        public ProductPriceDTO FindByID(int? id)
        {
            ProductPrice c = _uow.ProductPrices.FindById(id);

            return MapDTO.Map<ProductPriceDTO, ProductPrice>(c);
        }

        public void Delete(ProductPriceDTO c)
        {
            _uow.ProductPrices.Remove(MapDTO.Map<ProductPrice, ProductPriceDTO>(c));
        }

        public List<ProductPriceDTO> GetAll()
        {
            return MapDTO.MapList<ProductPriceDTO, ProductPrice>(_uow.ProductPrices.GetAll());
        }

        public ProductPriceDTO Update(ProductPriceDTO c)
        {
            _uow.ProductPrices.Modify(MapDTO.Map<ProductPrice, ProductPriceDTO>(c));
            return c;
        }
    }
}


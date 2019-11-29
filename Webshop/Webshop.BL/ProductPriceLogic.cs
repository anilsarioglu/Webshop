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

        public ProductPriceLogic()
        {
            _uow = new UnitOfWork();
        }

        public static ProductPrice Map(ProductPriceDTO e)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductPriceDTO, ProductPrice>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            ProductPrice dto = mapper.Map<ProductPrice>(e);
            return dto;

        }
        public static ProductPriceDTO Map(ProductPrice e)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductPrice, ProductPriceDTO>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            ProductPriceDTO dto = mapper.Map<ProductPriceDTO>(e);
            return dto;

        }

        public void Create(ProductPriceDTO c)
        {
            _uow.ProductPriceRepo.Add(Map(c));
            _uow.Save();
        }

        public ProductPriceDTO FindByID(int? id)
        {
            ProductPrice c = _uow.ProductPriceRepo.FindById(id);

            return Map(c);
        }

        public void Delete(ProductPriceDTO c)
        {
            _uow.ProductPriceRepo.Remove(Map(c));
            _uow.Save();
        }

        public List<ProductPriceDTO> GetAll()
        {
            List<ProductPrice> productPrices = _uow.ProductPriceRepo.GetAll();
            List<ProductPriceDTO> productPriceDtos = new List<ProductPriceDTO>();

            foreach (ProductPrice c in productPrices)
            {
                productPriceDtos.Add(Map(c));
            }

            return productPriceDtos;
        }

        public void Update(ProductPriceDTO c)
        {

            _uow.ProductPriceRepo.Modify(Map(c));
            _uow.Save();

        }
    }
}


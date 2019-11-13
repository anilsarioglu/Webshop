using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.Domain;

namespace Webshop.BL
{
    public class ProductPriceLogic
    {
        private ProductPriceRepo _productPriceRepo = new ProductPriceRepo();


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
            _productPriceRepo.Add(Map(c));
        }

        public ProductPriceDTO FindByID(int? id)
        {
            ProductPrice c = _productPriceRepo.FindById(id);

            return Map(c);
        }

        public void Delete(ProductPriceDTO c)
        {
            _productPriceRepo.Remove(Map(c));
        }

        public List<ProductPriceDTO> GetAll()
        {
            List<ProductPrice> productPrices = _productPriceRepo.GetAll();
            List<ProductPriceDTO> productPriceDtos = new List<ProductPriceDTO>();

            foreach (ProductPrice c in productPrices)
            {
                productPriceDtos.Add(Map(c));
            }

            return productPriceDtos;
        }

        public void Update(ProductPriceDTO c)
        {

            _productPriceRepo.Modify(Map(c));

        }
    }
}


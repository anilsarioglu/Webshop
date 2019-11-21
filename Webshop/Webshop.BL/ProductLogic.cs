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
    public class ProductLogic
    {
        private ProductRepo _productRepo  = new ProductRepo();

        public static Product Map(ProductDTO e)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, Product>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            Product dto = mapper.Map<Product>(e);
            return dto;

        }
        public static ProductDTO Map(Product e)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            ProductDTO dto = mapper.Map<ProductDTO>(e);
            return dto;

        }

        public void Create(ProductDTO c)
        {
            _productRepo.Add(Map(c));
        }

        public ProductDTO FindByID(int? id)
        {
            Product c = _productRepo.FindById(id);

            return Map(c);
        }

        public void Delete(ProductDTO c)
        {
            _productRepo.Remove(Map(c));
        }

        public List<ProductDTO> GetAll()
        {
            List<Product> products = _productRepo.GetAll();
            List<ProductDTO> productDtos = new List<ProductDTO>();

            foreach (Product c in products)
            {
                productDtos.Add(Map(c));
            }

            return productDtos;
        }

        public void Update(ProductDTO c)
        {

            _productRepo.Modify(Map(c));

        }
    }
}

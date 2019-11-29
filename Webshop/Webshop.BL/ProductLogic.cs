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
    public class ProductLogic : ILogic<ProductDTO>
    {
        private UnitOfWork _uow;

        public ProductLogic()
        {
            _uow = new UnitOfWork();
        }

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
            _uow.ProductRepo.Add(Map(c));
            _uow.Save();
        }

        public ProductDTO FindByID(int? id)
        {
            Product c = _uow.ProductRepo.FindById(id);

            return Map(c);
        }

        public void Delete(ProductDTO c)
        {
            _uow.ProductRepo.Remove(Map(c));
            _uow.Save();
        }

        public List<ProductDTO> GetAll()
        {

            List<Product> products = _uow.ProductRepo.GetAll();
            List<ProductDTO> productDtos = new List<ProductDTO>();

            foreach (Product c in products)
            {
                productDtos.Add(Map(c));
            }

            return productDtos;
        }

        public void Update(ProductDTO c)
        {

            _uow.ProductRepo.Modify(Map(c));
            _uow.Save();

        }
    }
}

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
    public class ProductPriceLogic : ILogic<ProductPriceDTO>
    {
        private IRepository<ProductPrice> _productPriceRepo;

        public ProductPriceLogic(ProductPriceRepo repo)
        {
            _productPriceRepo = repo;
        }

        public void Create(ProductPriceDTO c)
        {
            _productPriceRepo.Add(MapDTO.Map<ProductPrice, ProductPriceDTO>(c));
        }

        public ProductPriceDTO FindByID(int? id)
        {
            ProductPrice c = _productPriceRepo.FindById(id);

            return MapDTO.Map<ProductPriceDTO, ProductPrice>(c);
        }

        public void Delete(ProductPriceDTO c)
        {
            _productPriceRepo.Remove(MapDTO.Map<ProductPrice, ProductPriceDTO>(c));
        }

        public List<ProductPriceDTO> GetAll()
        {
            List<ProductPrice> productPrices = _productPriceRepo.GetAll();
            List<ProductPriceDTO> productPriceDtos = new List<ProductPriceDTO>();

            foreach (ProductPrice c in productPrices)
            {
                productPriceDtos.Add(MapDTO.Map<ProductPriceDTO, ProductPrice>(c));
            }

            return productPriceDtos;
        }

        public void Update(ProductPriceDTO c)
        {

            _productPriceRepo.Modify(MapDTO.Map<ProductPrice, ProductPriceDTO>(c));

        }
    }
}


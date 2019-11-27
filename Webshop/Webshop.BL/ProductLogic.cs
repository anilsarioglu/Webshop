using System.Collections.Generic;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.Domain;

namespace Webshop.BL
{
    public class ProductLogic : ILogic<ProductDTO>
    {
        private IRepository<Product> _productRepo;

        public ProductLogic(ProductRepo repo)
        {
            _productRepo = repo;
        }

        public void Create(ProductDTO c)
        {
            _productRepo.Add(MapDTO.Map<Product, ProductDTO>(c));
        }

        public ProductDTO FindByID(int? id)
        {
            Product c = _productRepo.FindById(id);

            return MapDTO.Map<ProductDTO, Product>(c);
        }

        public void Delete(ProductDTO c)
        {
            _productRepo.Remove(MapDTO.Map<Product, ProductDTO>(c));
        }

        public List<ProductDTO> GetAll()
        {

            List<Product> products = _productRepo.GetAll();
            List<ProductDTO> productDtos = new List<ProductDTO>();

            foreach (Product c in products)
            {
                productDtos.Add(MapDTO.Map<ProductDTO, Product>(c));
            }

            return productDtos;
        }

        public void Update(ProductDTO c)
        {

            _productRepo.Modify(MapDTO.Map<Product, ProductDTO>(c));

        }
    }
}

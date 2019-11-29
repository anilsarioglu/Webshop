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

        public ProductLogic(UnitOfWork uow)
        {
            _uow = uow;
        }

        public ProductDTO Create(ProductDTO c)
        {
            _uow.ProductRepo.Add(MapDTO.Map<Product, ProductDTO>(c));
            return c;
        }

        public ProductDTO FindByID(int? id)
        {
            Product c = _uow.ProductRepo.FindById(id);

            return MapDTO.Map<ProductDTO, Product>(c);
        }

        public void Delete(ProductDTO c)
        {
            _uow.ProductRepo.Remove(MapDTO.Map<Product, ProductDTO>(c));
        }

        public List<ProductDTO> GetAll()
        {
            return MapDTO.MapList<ProductDTO, Product>(_uow.ProductRepo.GetAll());
        }

        public ProductDTO Update(ProductDTO c)
        {
            _uow.ProductRepo.Modify(MapDTO.Map<Product, ProductDTO>(c));
            return c;
        }
    }
}

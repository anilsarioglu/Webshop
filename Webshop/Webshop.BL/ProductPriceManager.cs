using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;

namespace Webshop.BL
{
    class ProductPriceManager : IManager<ProductPrice>
    {
        private ProductPriceRepo repo;

        public ProductPriceManager()
        {
            repo = new ProductPriceRepo();
        }

        public void Add(ProductPrice t)
        {
            repo.Add(t);
        }

        public ProductPrice FinById(int? id)
        {
            return repo.FindById(id);
        }

        public void Modify()
        {
            repo.Modify();
        }

        public List<ProductPrice> GetAll()
        {
            return repo.GetAll();
        }

        public void Remove(ProductPrice t)
        {
            repo.Remove(t);
        }
    }
}

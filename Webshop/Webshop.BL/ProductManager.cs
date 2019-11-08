﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;

namespace Webshop.BL
{
    public class ProductManager : IManager<Product>
    {
        private ProductRepo repo;

        public ProductManager()
        {
            repo = new ProductRepo();
        }

        public void Add(Product t)
        {
            repo.Add(t);
        }

        public Product FinById(int? id)
        {
            return repo.FindById(id);
        }

        public void Modify()
        {
            repo.Modify();
        }

        public List<Product> GetAll()
        {
            return repo.GetAll();
        }

        public void Remove(Product t)
        {
            repo.Remove(t);
        }
    }
}

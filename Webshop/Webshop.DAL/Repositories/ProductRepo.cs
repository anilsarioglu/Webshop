using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class ProductRepo : IRepository<Products>
    {
        private WebshopContext _webshopContext = new WebshopContext();

        public void Add(Products t)
        {
            _webshopContext._Productses.Add(t);
            _webshopContext.SaveChanges();
        }

        public Products FinById(int? id)
        {
            return _webshopContext._Productses.Find(id);
        }

        public void Modify()
        {
            _webshopContext._Productses.AddOrUpdate();
            _webshopContext.SaveChanges();
        }

        public List<Products> GetAll()
        {
            return _webshopContext._Productses.ToList();
        }

        public void Remove(Products t)
        {
            _webshopContext._Productses.Remove(t);
            _webshopContext.SaveChanges();
        }
    }
}

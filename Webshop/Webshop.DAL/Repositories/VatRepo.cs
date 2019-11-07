using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class VatRepo : IRepository<Vat>
    {
        private WebshopContext _webshopContext = new WebshopContext();

        public void Add(Vat t)
        {
            _webshopContext._Vats.Add(t);
            _webshopContext.SaveChanges();
        }

        public Vat FindById(int? id)
        {
            return _webshopContext._Vats.Find(id);
        }

        public void Modify()
        {
            _webshopContext._Vats.AddOrUpdate();
            _webshopContext.SaveChanges();
        }

        public List<Vat> GetAll()
        {
            return _webshopContext._Vats.ToList();
        }

        public void Remove(Vat t)
        {
            _webshopContext._Vats.Remove(t);
            _webshopContext.SaveChanges();
        }
    }
}

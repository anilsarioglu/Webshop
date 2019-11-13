using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class VatRepo : IRepository<Vat>
    {
        private WebshopContext _webshopContext = new WebshopContext();

        public void Create(Vat t)
        {
            _webshopContext._Vats.Add(t);
            _webshopContext.SaveChanges();
        }

        public Vat Read(int? id)
        {
            return _webshopContext._Vats.Find(id);
        }

        public void Modify(Vat vat)
        {
            _webshopContext._Vats.AddOrUpdate();
            _webshopContext.SaveChanges();
        }

        public List<Vat> ReadAll()
        {
            return _webshopContext._Vats.ToList();
        }

        public void Delete(Vat t)
        {
            _webshopContext._Vats.Remove(t);
            _webshopContext.SaveChanges();
        }
    }
}

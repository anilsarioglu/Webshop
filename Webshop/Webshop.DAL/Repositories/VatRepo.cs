using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Repositories
{
    public class VatRepo : IRepository<Vat>
    {
        private WebshopContext _webshopContext;
        public VatRepo(WebshopContext context)
        {
            _webshopContext = context;
        }

        public void Add(Vat t)
        {
            _webshopContext._Vats.Add(t);
          
        }

        public Vat FindById(int? id)
        {
            return _webshopContext._Vats.Find(id);
        }

        public void Modify(Vat vat)
        {
            _webshopContext._Vats.AddOrUpdate();
           
        }

        public List<Vat> GetAll()
        {
            return _webshopContext._Vats.ToList();
        }

        public void Remove(Vat t)
        {
            _webshopContext.Entry(t).State = EntityState.Deleted;

        }
    }
}

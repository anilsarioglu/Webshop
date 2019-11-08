using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;

namespace Webshop.BL
{
    public class VatManager : IManager<Vat>
    {
        private VatRepo repo;

        public VatManager()
        {
            repo = new VatRepo();
        }

        public void Add(Vat t)
        {
            repo.Add(t);
        }

        public Vat FinById(int? id)
        {
            return repo.FindById(id);
        }

        public void Modify()
        {
            repo.Modify();
        }

        public List<Vat> GetAll()
        {
            return repo.GetAll();
        }

        public void Remove(Vat t)
        {
            repo.Remove(t);
        }
    }
}

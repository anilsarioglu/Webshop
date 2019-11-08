using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;

namespace Webshop.BL
{
    public class InvoiceManager : IManager<Invoice>
    {
        private InvoiceRepo repo;

        public InvoiceManager()
        {
            repo = new InvoiceRepo();
        }

        public void Add(Invoice t)
        {
            repo.Add(t);
        }

        public Invoice FinById(int? id)
        {
            return repo.FindById(id);
        }

        public void Modify()
        {
            repo.Modify();
        }

        public List<Invoice> GetAll()
        {
            return repo.GetAll();
        }

        public void Remove(Invoice t)
        {
            repo.Remove(t);
        }
    }
}

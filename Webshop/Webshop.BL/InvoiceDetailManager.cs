using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;

namespace Webshop.BL
{
    public class InvoiceDetailManager : IManager<InvoiceDetail>
    {
        private InvoiceDetailRepo repo;

        public InvoiceDetailManager()
        {
            repo = new InvoiceDetailRepo();
        }

        public void Add(InvoiceDetail t)
        {
            repo.Add(t);
        }

        public InvoiceDetail FinById(int? id)
        {
            return repo.FindById(id);
        }

        public void Modify()
        {
            repo.Modify();
        }

        public List<InvoiceDetail> GetAll()
        {
            return repo.GetAll();
        }

        public void Remove(InvoiceDetail t)
        {
            repo.Remove(t);
        }
    }
}

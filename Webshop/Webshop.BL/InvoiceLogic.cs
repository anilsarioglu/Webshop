using System.Collections.Generic;
using System.Linq;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.Domain;

namespace Webshop.BL
{
    public class InvoiceLogic : ILogic<InvoiceDTO>
    {
        private IRepository<Invoice> _invoiceRepo;

        public InvoiceLogic(InvoiceRepo repo)
        {
            _invoiceRepo = repo;
        }

        public void Create(InvoiceDTO c)
        {
            _invoiceRepo.Add(MapDTO.Map<Invoice, InvoiceDTO>(c));
        }

        public InvoiceDTO FindByID(int? id)
        {
            Invoice c = _invoiceRepo.FindById(id);

            return MapDTO.Map<InvoiceDTO, Invoice>(c);
        }

        public void Delete(InvoiceDTO c)
        {
            _invoiceRepo.Remove(MapDTO.Map<Invoice, InvoiceDTO>(c));
        }


        public List<InvoiceDTO> GetAll()
        {
            return MapDTO.MapList<InvoiceDTO, Invoice>(_invoiceRepo.GetAll()).ToList();
        }

        public void Update(InvoiceDTO c)
        {
            _invoiceRepo.Modify(MapDTO.Map<Invoice, InvoiceDTO>(c));
        }
    }
}

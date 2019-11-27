using System.Collections.Generic;
using System.Linq;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.Domain;

namespace Webshop.BL
{
    public class InvoiceDetailLogic : ILogic<InvoiceDetailDTO>
    {
        private IRepository<InvoiceDetail> _invoiceDetailRepo;

        public InvoiceDetailLogic(InvoiceDetailRepo repo)
        {
            _invoiceDetailRepo = repo;
        }

        public void Create(InvoiceDetailDTO c)
        {
            _invoiceDetailRepo.Add(MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(c));
        }

        public InvoiceDetailDTO FindByID(int? id)
        {
            InvoiceDetail c = _invoiceDetailRepo.FindById(id);

            return MapDTO.Map<InvoiceDetailDTO, InvoiceDetail>(c);
        }

        public void Delete(InvoiceDetailDTO c)
        {
            _invoiceDetailRepo.Remove(MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(c));
        }

        public List<InvoiceDetailDTO> GetAll()
        {
            return MapDTO.MapList<InvoiceDetailDTO, InvoiceDetail>(_invoiceDetailRepo.GetAll()).ToList();
        }

        public void Update(InvoiceDetailDTO c)
        {
            _invoiceDetailRepo.Modify(MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(c));
        }
    }
}


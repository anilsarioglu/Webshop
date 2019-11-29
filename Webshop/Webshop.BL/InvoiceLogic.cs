using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Webshop.DAL;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.DAL.UnitOfWork;
using Webshop.Domain;

namespace Webshop.BL
{
    public class InvoiceLogic : ILogic<InvoiceDTO>
    {
        private UnitOfWork _uow;

        public InvoiceLogic(UnitOfWork uow)
        {
            _uow = uow;
        }

        public void Create(InvoiceDTO c)
        {
            _uow.InvoiceRepo.Add(MapDTO.Map<Invoice, InvoiceDTO>(c));

        }

        public InvoiceDTO FindByID(int? id)
        {
            Invoice c = _uow.InvoiceRepo.FindById(id);

            return MapDTO.Map<InvoiceDTO, Invoice>(c);
        }

        public void Delete(InvoiceDTO c)
        {
            _uow.InvoiceRepo.Remove(MapDTO.Map<Invoice, InvoiceDTO>(c));
        }


        public List<InvoiceDTO> GetAll()
        {
            return MapDTO.MapList<InvoiceDTO, Invoice>(_uow.InvoiceRepo.GetAll());
        }

    public void Update(InvoiceDTO c)
        {
            _uow.InvoiceRepo.Modify(MapDTO.Map<Invoice, InvoiceDTO>(c));
        }
    }
}

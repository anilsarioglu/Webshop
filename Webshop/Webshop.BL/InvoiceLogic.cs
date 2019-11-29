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

        public InvoiceDTO Create(InvoiceDTO c)
        {
            _uow.Invoices.Add(MapDTO.Map<Invoice, InvoiceDTO>(c));
            return c;
        }

        public InvoiceDTO FindByID(int? id)
        {
            Invoice c = _uow.Invoices.FindById(id);

            return MapDTO.Map<InvoiceDTO, Invoice>(c);
        }

        public void Delete(InvoiceDTO c)
        {
            _uow.Invoices.Remove(MapDTO.Map<Invoice, InvoiceDTO>(c));
        }


        public List<InvoiceDTO> GetAll()
        {
            return MapDTO.MapList<InvoiceDTO, Invoice>(_uow.Invoices.GetAll());
        }

        public InvoiceDTO Update(InvoiceDTO c)
        {
            _uow.Invoices.Modify(MapDTO.Map<Invoice, InvoiceDTO>(c));
            return c;
        }
    }
}

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
    public class InvoiceDetailLogic : ILogic<InvoiceDetailDTO>
    {
        private UnitOfWork _uow;

        public InvoiceDetailLogic(UnitOfWork uow)
        {
            _uow = uow;
        }

        public InvoiceDetailDTO Create(InvoiceDetailDTO c)
        {
            _uow.InvoiceDetails.Add(MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(c));
            return c;
        }

        public InvoiceDetailDTO FindByID(int? id)
        {
            InvoiceDetail c = _uow.InvoiceDetails.FindById(id);

            return MapDTO.Map<InvoiceDetailDTO, InvoiceDetail>(c);
        }

        public void Delete(InvoiceDetailDTO c)
        {
            _uow.InvoiceDetails.Remove(MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(c));
        }

        public List<InvoiceDetailDTO> GetAll()
        {
            return MapDTO.MapList<InvoiceDetailDTO, InvoiceDetail>(_uow.InvoiceDetails.GetAll());
        }

        public InvoiceDetailDTO Update(InvoiceDetailDTO c)
        {
            _uow.InvoiceDetails.Modify(MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(c));
            return c;
        }
    }
}


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

        public InvoiceDetailLogic()
        {
            _uow = new UnitOfWork();
        }

   

        public void Create(InvoiceDetailDTO c)
        {
            _uow.InvoiceDetailRepo.Add(MapDTO.Map<InvoiceDetail,InvoiceDetailDTO>(c));
            _uow.Save();
        }

        public InvoiceDetailDTO FindByID(int? id)
        {
            InvoiceDetail c = _uow.InvoiceDetailRepo.FindById(id);

            return MapDTO.Map<InvoiceDetailDTO, InvoiceDetail>(c);
        }

        public void Delete(InvoiceDetailDTO c)
        {
            _uow.InvoiceDetailRepo.Remove(MapDTO.Map<InvoiceDetail,InvoiceDetailDTO>(c));
        }

        public List<InvoiceDetailDTO> GetAll()
        {

            return MapDTO.MapList<InvoiceDetailDTO,InvoiceDetail>(_uow.InvoiceDetailRepo.GetAll());
        }

        public void Update(InvoiceDetailDTO c)
        {

            _uow.InvoiceDetailRepo.Modify(MapDTO.Map<InvoiceDetail,InvoiceDetailDTO>(c));
            _uow.Save();

        }
    }
}


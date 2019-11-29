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

        public static InvoiceDetail Map(InvoiceDetailDTO e)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<InvoiceDetailDTO, InvoiceDetail>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            InvoiceDetail dto = mapper.Map<InvoiceDetail>(e);
            return dto;

        }
        public static InvoiceDetailDTO Map(InvoiceDetail e)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<InvoiceDetail, InvoiceDetailDTO>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            InvoiceDetailDTO dto = mapper.Map<InvoiceDetailDTO>(e);
            return dto;

        }

        public void Create(InvoiceDetailDTO c)
        {
            _uow.InvoiceDetails.Add(Map(c));
        }

        public InvoiceDetailDTO FindByID(int? id)
        {
            InvoiceDetail c = _uow.InvoiceDetails.FindById(id);

            return Map(c);
        }

        public void Delete(InvoiceDetailDTO c)
        {
            _uow.InvoiceDetails.Remove(Map(c));
        }

        public List<InvoiceDetailDTO> GetAll()
        {
            List<InvoiceDetail> invoiceDetails = _uow.InvoiceDetails.GetAll();
            List<InvoiceDetailDTO> invoiceDtos = new List<InvoiceDetailDTO>();

            foreach (InvoiceDetail c in invoiceDetails)
            {
                invoiceDtos.Add(Map(c));
            }

            return invoiceDtos;
        }

        public void Update(InvoiceDetailDTO c)
        {

            _uow.InvoiceDetails.Modify(Map(c));

        }
    }
}


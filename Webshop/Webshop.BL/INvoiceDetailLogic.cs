using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.Domain;

namespace Webshop.BL
{
    public class InvoiceDetailLogic
    {
        private InvoiceDetailRepo _invoiceDetailRepo = new InvoiceDetailRepo();


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
            _invoiceDetailRepo.Add(Map(c));
        }

        public InvoiceDetailDTO FindByID(int? id)
        {
            InvoiceDetail c = _invoiceDetailRepo.FindById(id);

            return Map(c);
        }

        public void Delete(InvoiceDetailDTO c)
        {
            _invoiceDetailRepo.Remove(Map(c));
        }

        public List<InvoiceDetailDTO> GetAll()
        {
            List<InvoiceDetail> invoiceDetails = _invoiceDetailRepo.GetAll();
            List<InvoiceDetailDTO> invoiceDtos = new List<InvoiceDetailDTO>();

            foreach (InvoiceDetail c in invoiceDetails)
            {
                invoiceDtos.Add(Map(c));
            }

            return invoiceDtos;
        }

        public void Update(InvoiceDetailDTO c)
        {

            _invoiceDetailRepo.Modify(Map(c));

        }
    }
}


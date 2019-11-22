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
    public class InvoiceLogic
    {
        private InvoiceRepo _invoiceRepo = new InvoiceRepo();

        public static Invoice Map(InvoiceDTO e)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<InvoiceDTO, Invoice>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            Invoice dto = mapper.Map<Invoice>(e);
            return dto;

        }
        public static InvoiceDTO Map(Invoice e)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Invoice, InvoiceDTO>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            InvoiceDTO dto = mapper.Map<InvoiceDTO>(e);
            return dto;

        }

        public void Create(InvoiceDTO c)
        {
            _invoiceRepo.Add(Map(c));
        }

        public InvoiceDTO FindByID(int? id)
        {
            Invoice c = _invoiceRepo.FindById(id);

            return Map(c);
        }

        public void Delete(InvoiceDTO c)
        {
            _invoiceRepo.Remove(Map(c));
        }


        public List<InvoiceDTO> GetAll()
        {
          List<Invoice> invoices = _invoiceRepo.GetAll();
          List<InvoiceDTO> invoiceDTO = new List<InvoiceDTO>();

          foreach (Invoice c in invoices)
          {
             invoiceDTO.Add(Map(c));
          }

         return invoiceDTO;
        }

    public void Update(InvoiceDTO c)
        {

            _invoiceRepo.Modify(Map(c));

        }
    }
}

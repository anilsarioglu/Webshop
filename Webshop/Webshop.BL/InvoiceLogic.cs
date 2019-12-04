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
        private static readonly log4net.ILog log = log4net.LogManager
            .GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InvoiceLogic(UnitOfWork uow)
        {
            _uow = uow;
        }

        public void Create(InvoiceDTO c)
        {
            try
            {
                _uow.InvoiceRepo.Add(MapDTO.Map<Invoice, InvoiceDTO>(c));
                _uow.Save();
            }
            catch (Exception e)
            {
                log.Error("kon geen factuur toevoegen",e);
                throw new Exception(e.Message);
            }
          

        }

        public InvoiceDTO FindByID(int? id)
        {
            Invoice c = _uow.InvoiceRepo.FindById(id);

            return MapDTO.Map<InvoiceDTO, Invoice>(c);
        }

        public void Delete(InvoiceDTO c)
        {
            _uow.InvoiceRepo.Remove(MapDTO.Map<Invoice, InvoiceDTO>(c));
            _uow.Save();
        }


        public List<InvoiceDTO> GetAll()
        {
            return MapDTO.MapList<InvoiceDTO, Invoice>(_uow.InvoiceRepo.GetAll());
        }

    public void Update(InvoiceDTO c)
        {
            _uow.InvoiceRepo.Modify(MapDTO.Map<Invoice, InvoiceDTO>(c));
            _uow.Save();
        }
    }
}

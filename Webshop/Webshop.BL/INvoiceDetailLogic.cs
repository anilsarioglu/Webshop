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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InvoiceDetailLogic(UnitOfWork uow)
        {
            _uow = uow;
        }

        public InvoiceDetailDTO Create(InvoiceDetailDTO c)
        {
            try
            {
                var invoiceDetail = MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(c);
                _uow.InvoiceDetailRepo.Add(invoiceDetail);
                _uow.Save();

                c.Id = invoiceDetail.Id;

                return c;
            }
            catch (Exception e)
            {
                log.Error("kon geen factuur toeveogen");
                throw new Exception(e.Message);
            }
        }

        public InvoiceDetailDTO FindByID(int? id)
        {
            try
            {
                var c = _uow.InvoiceDetailRepo.FindById(id);

                return c == null ? null : MapDTO.Map<InvoiceDetailDTO, InvoiceDetail>(c);
            }
            catch (Exception e)
            {
                log.Error("kon geen id van factuur vinden",e);
                throw new Exception(e.Message);
            }   
        }

        public void Delete(InvoiceDetailDTO c)
        {
            try
            {
                _uow.InvoiceDetailRepo.Remove(MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(c));
                _uow.Save();
            }
            catch (Exception e)
            {
                log.Error("kon geen factuur verwijderen",e);
                throw new Exception(e.Message);
            }
        }

        public void Delete(int id)
        {
          throw new NotImplementedException();
        }

        public List<InvoiceDetailDTO> GetAll()
        {
            try
            {
                return MapDTO.MapList<InvoiceDetailDTO, InvoiceDetail>(_uow.InvoiceDetailRepo.GetAll());
            }
            catch (Exception e)
            {
                log.Error("kon geen facturen ophalen",e);
                throw new Exception(e.Message);
            }
        }

        public InvoiceDetailDTO Update(InvoiceDetailDTO c)
        {
            try
            {
                _uow.InvoiceDetailRepo.Modify(MapDTO.Map<InvoiceDetail, InvoiceDetailDTO>(c));
                _uow.Save();
                return c;
            }
            catch (Exception e)
            {
                log.Error("kon geen factuur aanpassen",e);
                throw new Exception(e.Message);
            }
        }
    }
}


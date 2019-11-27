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
    public class VatLogic : ILogic<VatDTO>
    {
        private UnitOfWork _uow;

        public VatLogic()
        {
            _uow = new UnitOfWork(new WebshopContext());
        }

        public static Vat Map(VatDTO e)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<VatDTO, Vat>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            Vat dto = mapper.Map<Vat>(e);
            return dto;

        }
        public static VatDTO Map(Vat e)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vat, VatDTO>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            VatDTO dto = mapper.Map<VatDTO>(e);
            return dto;

        }

        public void Create(VatDTO c)
        {
            _uow.Vats.Add(Map(c));
        }

        public VatDTO FindByID(int? id)
        {
            Vat c = _uow.Vats.FindById(id);

            return Map(c);
        }

        public void Delete(VatDTO c)
        {
            _uow.Vats.Remove(Map(c));
        }

        public List<VatDTO> GetAll()
        {
            List<Vat> vats = _uow.Vats.GetAll();
            List<VatDTO> vatDtos = new List<VatDTO>();

            foreach (Vat c in vats)
            {
                vatDtos.Add(Map(c));
            }

            return vatDtos;
        }

        public void Update(VatDTO c)
        {

            _uow.Vats.Modify(Map(c));

        }
    }
}


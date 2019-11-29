﻿using System;
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

        public VatLogic(UnitOfWork uow)
        {
            _uow = uow;
        }

        public VatDTO Create(VatDTO c)
        {
            _uow.Vats.Add(MapDTO.Map<Vat, VatDTO>(c));
            return c;
        }

        public VatDTO FindByID(int? id)
        {
            Vat c = _uow.Vats.FindById(id);

            return MapDTO.Map<VatDTO, Vat>(c);
        }

        public void Delete(VatDTO c)
        {
            _uow.Vats.Remove(MapDTO.Map<Vat, VatDTO>(c));
        }

        public List<VatDTO> GetAll()
        {
            return MapDTO.MapList<VatDTO, Vat>(_uow.Vats.GetAll());
        }

        public VatDTO Update(VatDTO c)
        {
            _uow.Vats.Modify(MapDTO.Map<Vat, VatDTO>(c));
            return c;
        }
    }
}


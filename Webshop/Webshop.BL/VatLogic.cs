using System.Collections.Generic;
using System.Linq;
using Webshop.DAL.Entit;
using Webshop.DAL.Repositories;
using Webshop.Domain;

namespace Webshop.BL
{
    public class VatLogic : ILogic<VatDTO>
    {
        private IRepository<Vat> _vatRepo;

        public VatLogic(VatRepo repo)
        {
            _vatRepo = repo;
        }

        public void Create(VatDTO c)
        {
            _vatRepo.Add(MapDTO.Map<Vat, VatDTO>(c));
        }

        public VatDTO FindByID(int? id)
        {
            Vat c = _vatRepo.FindById(id);

            return MapDTO.Map<VatDTO, Vat>(c);
        }

        public void Delete(VatDTO c)
        {
            _vatRepo.Remove(MapDTO.Map<Vat, VatDTO>(c));
        }

        public List<VatDTO> GetAll()
        {
            return MapDTO.MapList<VatDTO, Vat>(_vatRepo.GetAll()).ToList();
        }

        public void Update(VatDTO c)
        {
            _vatRepo.Modify(MapDTO.Map<Vat, VatDTO>(c));
        }
    }
}


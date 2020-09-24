using AutoMapper;
using HomeFinder.Data.Repository.Interfaces;
using HomeFinder.Services.Contracts;
using HomeFinder.Services.Domain;
using System.Threading.Tasks;

namespace HomeFinder.Services.Implementations
{
    public class HouseProspectService : IHouseProspectService
    {
        private readonly IMapper _mapper;
        private readonly IHouseProspectRepo _houseProspectRepo;

        public HouseProspectService(IMapper mapper, IHouseProspectRepo houseProspectRepo)
        {
            _mapper = mapper;
            _houseProspectRepo = houseProspectRepo;
        }
        public async Task<HouseProspect> Create(HouseProspect houseProspect)
        {
            var entity = _mapper.Map<Data.DataObjects.HouseProspect>(houseProspect);
            var result = await _houseProspectRepo.Create(entity);
            return _mapper.Map<HouseProspect>(result);
        }

        public async Task Delete(long key)
        {
            await _houseProspectRepo.Delete(key);
        }

        public async Task<HouseProspect> Read(long key)
        {
            var result = await _houseProspectRepo.Read(key);
            return _mapper.Map<HouseProspect>(result);
        }

        public async Task<HouseProspect> Update(HouseProspect houseProspect)
        {
            var entity = _mapper.Map<Data.DataObjects.HouseProspect>(houseProspect);
            var result = await _houseProspectRepo.Update(entity);
            return _mapper.Map<HouseProspect>(result);
        }
    }
}


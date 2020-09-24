using AutoMapper;
using HomeFinder.Data.Repository.Interfaces;
using HomeFinder.Services.Contracts;
using HomeFinder.Services.Domain;
using System.Threading.Tasks;

namespace HomeFinder.Services.Implementations
{
    public class HouseService : IHouseService
    {
        private readonly IMapper _mapper;
        private readonly IHouseRepo _houseRepo;

        public HouseService(IMapper mapper, IHouseRepo houseRepo)
        {
            _mapper = mapper;
            _houseRepo = houseRepo;
        }
        public async Task<House> Create(House house)
        {
            var entity = _mapper.Map<Data.DataObjects.House>(house);
            var result = await _houseRepo.Create(entity);
            return _mapper.Map<House>(result);
        }

        public async Task Delete(long key)
        {
            await _houseRepo.Delete(key);
        }

        public async Task<House> Read(long key)
        {
            var result = await _houseRepo.Read(key);
            return _mapper.Map<House>(result);
        }

        public async Task<House> Update(House house)
        {
            var entity = _mapper.Map<Data.DataObjects.House>(house);
            var result = await _houseRepo.Update(entity);
            return _mapper.Map<House>(result);
        }
    }
}


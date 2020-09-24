using AutoMapper;
using HomeFinder.Data.Repository.Interfaces;
using HomeFinder.Services.Contracts;
using HomeFinder.Services.Domain;
using System.Threading.Tasks;

namespace HomeFinder.Services.Implementations
{
    public class BuyerService : IBuyerService
    {
        private readonly IMapper _mapper;
        private readonly IBuyerRepo _buyerRepo;

        public BuyerService(IMapper mapper, IBuyerRepo buyerRepo)
        {
            _mapper = mapper;
            _buyerRepo = buyerRepo;
        }
        public async Task<Buyer> Create(Buyer buyer)
        {
            var entity = _mapper.Map<Data.DataObjects.Buyer>(buyer);
            var result = await _buyerRepo.Create(entity);
            return _mapper.Map<Buyer>(result);
        }
        
        public async Task Delete(long key)
        {
            await _buyerRepo.Delete(key);
        }

        public async Task<Buyer> Read(long key)
        {
            var result = await _buyerRepo.Read(key);
            return _mapper.Map<Buyer>(result);
        }
        
        public async Task<Buyer> Update(Buyer buyer)
        {
            var entity = _mapper.Map<Data.DataObjects.Buyer>(buyer);
            var result = await _buyerRepo.Update(entity);
            return _mapper.Map<Buyer>(result);
        }
    }
}

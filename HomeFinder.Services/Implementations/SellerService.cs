using AutoMapper;
using HomeFinder.Data.Repository.Interfaces;
using HomeFinder.Services.Contracts;
using HomeFinder.Services.Domain;
using System.Threading.Tasks;

namespace HomeFinder.Services.Implementations
{
    public class SellerService : ISellerService
    {
        private readonly IMapper _mapper;
        private readonly ISellerRepo _sellerRepo;

        public SellerService(IMapper mapper, ISellerRepo sellerRepo)
        {
            _mapper = mapper;
            _sellerRepo = sellerRepo;
        }
        public async Task<Seller> Create(Seller seller)
        {
            var entity = _mapper.Map<Data.DataObjects.Seller>(seller);
            var result = await _sellerRepo.Create(entity);
            return _mapper.Map<Seller>(result);
        }

        public async Task Delete(long key)
        {
            await _sellerRepo.Delete(key);
        }

        public async Task<Seller> Read(long key)
        {
            var result = await _sellerRepo.Read(key);
            return _mapper.Map<Seller>(result);
        }

        public async Task<Seller> Update(Seller seller)
        {
            var entity = _mapper.Map<Data.DataObjects.Seller>(seller);
            var result = await _sellerRepo.Update(entity);
            return _mapper.Map<Seller>(result);
        }
    }
}


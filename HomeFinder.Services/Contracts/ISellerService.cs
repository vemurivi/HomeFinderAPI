using HomeFinder.Services.Domain;
using System.Threading.Tasks;

namespace HomeFinder.Services.Contracts
{
    public interface ISellerService
    {
        Task<Seller> Create(Seller seller);
        Task<Seller> Read(long key);
        Task<Seller> Update(Seller seller);
        Task Delete(long key);
    }
}

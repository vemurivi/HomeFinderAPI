using HomeFinder.Services.Domain;
using System.Threading.Tasks;

namespace HomeFinder.Services.Contracts
{
    public interface IBuyerService
    {
        Task<Buyer> Create(Buyer buyer);
        Task<Buyer> Read(long key);
        Task<Buyer> Update(Buyer buyer);
        Task Delete(long key);
    }
}

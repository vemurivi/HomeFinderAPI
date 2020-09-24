using HomeFinder.Services.Domain;
using System.Threading.Tasks;

namespace HomeFinder.Services.Contracts
{
    public interface IHouseService
    {
        Task<House> Create(House house);
        Task<House> Read(long key);
        Task<House> Update(House house);
        Task Delete(long key);
    }
}

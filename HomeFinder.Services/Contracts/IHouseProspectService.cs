using HomeFinder.Services.Domain;
using System.Threading.Tasks;

namespace HomeFinder.Services.Contracts
{
    public interface IHouseProspectService
    {
        Task<HouseProspect> Create(HouseProspect houseProspect);
        Task<HouseProspect> Read(long key);
        Task<HouseProspect> Update(HouseProspect houseProspect);
        Task Delete(long key);
    }
}

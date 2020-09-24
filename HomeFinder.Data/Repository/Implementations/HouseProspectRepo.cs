using HomeFinder.Data.DataObjects;
using HomeFinder.Data.Repository.Interfaces;

namespace HomeFinder.Data.Repository.Implementations
{
    public class HouseProspectRepo : BaseRepo<HouseProspect>, IHouseProspectRepo
    {
        public HouseProspectRepo(IHouseDBContext context) : base(context)
        {

        }
    }
}

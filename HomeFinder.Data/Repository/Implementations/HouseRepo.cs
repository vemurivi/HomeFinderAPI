using HomeFinder.Data.DataObjects;
using HomeFinder.Data.Repository.Interfaces;

namespace HomeFinder.Data.Repository.Implementations
{
    public class HouseRepo : BaseRepo<House>, IHouseRepo
    {
        public HouseRepo(IHouseDBContext context) : base(context)
        {

        }
    }
}

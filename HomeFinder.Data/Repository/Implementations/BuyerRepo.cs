using HomeFinder.Data.DataObjects;
using HomeFinder.Data.Repository.Interfaces;

namespace HomeFinder.Data.Repository.Implementations
{
    public class BuyerRepo : BaseRepo<Buyer>, IBuyerRepo
    {
        public BuyerRepo(IHouseDBContext context) : base(context)
        {

        }
    }
}

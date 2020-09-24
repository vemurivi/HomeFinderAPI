using HomeFinder.Data.DataObjects;
using HomeFinder.Data.Repository.Interfaces;

namespace HomeFinder.Data.Repository.Implementations
{
    public class SellerRepo : BaseRepo<Seller>, ISellerRepo
    {
        public SellerRepo(IHouseDBContext context) : base(context)
        {

        }
    }
}

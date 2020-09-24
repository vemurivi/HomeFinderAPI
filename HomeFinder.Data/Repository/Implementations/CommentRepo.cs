using HomeFinder.Data.DataObjects;
using HomeFinder.Data.Repository.Interfaces;

namespace HomeFinder.Data.Repository.Implementations
{
    public class CommentRepo : BaseRepo<Comment>, ICommentRepo
    {
        public CommentRepo(IHouseDBContext context) : base(context)
        {

        }
    }
}

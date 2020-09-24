using HomeFinder.Services.Domain;
using System.Threading.Tasks;

namespace HomeFinder.Services.Contracts
{
    public interface ICommentService
    {
        Task<Comment> Create(Comment comment);
        Task<Comment> Read(long key);
        Task<Comment> Update(Comment comment);
        Task Delete(long key);
    }
}

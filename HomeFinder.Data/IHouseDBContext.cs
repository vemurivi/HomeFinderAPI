using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading;
using System.Threading.Tasks;

namespace HomeFinder.Data
{
    public interface IHouseDBContext
    {
        EntityEntry Remove(object entity);

        Task<int> SaveChangesAsync(CancellationToken token);

        DbSet<T> Set<T>() where T : class;
    }
}

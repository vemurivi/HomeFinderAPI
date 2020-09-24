using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HomeFinder.Data.Repository
{
    public abstract class BaseRepo<T> : IGenericRepo<T> where T : class
    {
        protected readonly IHouseDBContext _houseDBContext;

        public BaseRepo(IHouseDBContext houseDBContext)
        {
            _houseDBContext = houseDBContext;

        }

        public async Task<T> Create(T entity)
        {
            await _houseDBContext.Set<T>().AddAsync(entity);
            await _houseDBContext.SaveChangesAsync(CancellationToken.None);
            return entity;

        }

        public async Task Delete(params object[] primarykey)
        {
            var entity = await _houseDBContext.Set<T>().FindAsync(primarykey);
            if (entity == null) throw new KeyNotFoundException();
            _houseDBContext.Set<T>().Remove(entity);
            await _houseDBContext.SaveChangesAsync(CancellationToken.None);
        }

        public async Task<List<T>> ReadAll()
        {
            return await Task.Run(() =>_houseDBContext.Set<T>().ToList());
        }

        public async Task<T> Read(params object[] primarykey)
        {
            return await _houseDBContext.Set<T>().FindAsync(primarykey);
        }

        public async Task SaveChanges()
        {
            await _houseDBContext.SaveChangesAsync(CancellationToken.None);
        }

        public async Task<T> Update(T entity, bool saveChanges = true)
        {
             _houseDBContext.Set<T>().Attach(entity);
           if(saveChanges) await _houseDBContext.SaveChangesAsync(CancellationToken.None);
            return entity;
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeFinder.Data.Repository
{
    public  interface IGenericRepo<T>  where T : class
    {

        Task<List<T>> ReadAll();
        Task<T> Read(params object[] primarykey);
        Task<T> Create(T entity);
        Task <T> Update(T entity, bool saveChanges = true);
        Task Delete(params object[] primarykey);
        Task SaveChanges();

    }
}

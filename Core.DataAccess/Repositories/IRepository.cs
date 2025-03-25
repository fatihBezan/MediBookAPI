
using Core.DataAccess.Entities;

namespace Core.DataAccess.Repositories
{
    public interface IRepository<TEntity ,TId> where TEntity :Entity<TId>
    {

    }
}



using Core.DataAccess.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Core.DataAccess.Repositories;

public abstract class EfRepositoryBase<TEntity, TId, TContext> : IRepository<TEntity, TId>
    where TEntity : Entity<TId>
    where TContext : DbContext
{
    TContext Context { get;}

    protected EfRepositoryBase(TContext context)
    {
        Context= context;
    }
    public TEntity Add(TEntity entity)
    {
        try
        {
            entity.CreatedTime = DateTime.Now; // DateTime.Now olarak düzeltildi
            Context.Set<TEntity>().Add(entity); // Doğru ekleme yöntemi
            Context.SaveChanges(); // SavedRange yerine SaveChanges
            return entity;
        }
        catch (DbUpdateException ex)
        {
            // Hata yönetimi
            if (ex.InnerException is SqlException sqlEx && sqlEx.Number == 547)
            {
                throw new Exception("Geçersiz HospitalId. Lütfen geçerli bir hastane ID'si sağlayın.", ex);
            }
            throw;
        }
    }
    //public TEntity Add(TEntity entity)
    //{
    //    //Set fonksiyonu burada => Context.(class) işlemi yapar
    //    entity.CreatedTime = DateTime.Now;
    //    Context.Entry(entity).State = EntityState.Added;
    //    Context.SaveChanges();
    //    return entity;

    //}

    public TEntity Delete(TEntity entity)
    {
        Context.Entry(entity).State = EntityState.Deleted;
        Context.SaveChanges();
        return entity;
    }

    

    public TEntity? GetById(TId id)
    {
       return Context.Set<TEntity>().Find(id);
    }

    public TEntity Update(TEntity entity)
    {
        entity.UpdateTime = DateTime.Now;
        Context.Entry(entity).State = EntityState.Modified;
        Context.SaveChanges();
        return entity;
    }

    public List<TEntity> GetAll(bool include =true)
    {
        IQueryable<TEntity> query = Context.Set<TEntity>();

        if(include is false)
        {
            query=query.IgnoreAutoIncludes();
        }

        return query.ToList();
    }
    public IQueryable<TEntity> Query()
    {
        return Context.Set<TEntity>();
    }
}

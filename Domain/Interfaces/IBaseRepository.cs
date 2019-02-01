using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetById(long id);
        long Add(TEntity document);
        long Update(TEntity document);
        bool Remove(long id);
    }
}

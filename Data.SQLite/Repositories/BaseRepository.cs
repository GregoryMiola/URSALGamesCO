using Data.SQLite.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.SQLite.Repositories
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        DbContext context;
        
        public BaseRepository(URSALGamesCOContext context) => this.context = context;
        
        public List<TEntity> GetAll()
        {
            // Set<TEntity> provides you an access to entity DbSet
            // Just like if you call context.Users or context.[AnyTableName]
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetById(long id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public long Add(TEntity document)
        {
            context.Set<TEntity>().Add(document);
            return context.SaveChanges();
        }

        public long Update(TEntity document)
        {
            try
            {
                context.Set<TEntity>().Update(document);

                // Attempt to save changes to the database
                return context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw ex;
            }
        }

        public bool Remove(long id)
        {
            var data = GetById(id);
            if (data != null)
            {
                context.Set<TEntity>().Remove(data);
            }

            return context.SaveChanges() > 0;
        }
    }
}

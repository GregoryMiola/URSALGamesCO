using Data.SQLite.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.SQLite.Repositories
{
    /// <summary>
    /// Repository base of solution
    /// </summary>
    /// <typeparam name="TEntity">Generic entity of solution</typeparam>
    public class BaseRepository<TEntity> where TEntity : class
    {
        #region Property

        /// <summary>
        /// Property of context of the database application
        /// </summary>
        DbContext context;

        #endregion Property

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="context">Context of database application</param>
        public BaseRepository(URSALGamesCOContext context) => this.context = context;

        #endregion Ctor

        #region Methods

        /// <summary>
        /// Method responsible for get all documents of this entity
        /// </summary>
        /// <returns>List of documents of this entity</returns>
        public List<TEntity> GetAll()
        {
            // Set<TEntity> provides you an access to entity DbSet
            // Just like if you call context.Users or context.[AnyTableName]
            return context.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Method responsible for get the document based on your id
        /// </summary>
        /// <param name="id">Entity identifier</param>
        /// <returns>The document based on your entity</returns>
        public TEntity GetById(long id)
        {
            return context.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Method responsible for add a new document of the entity
        /// </summary>
        /// <param name="document">Document being added</param>
        /// <returns>If you have added return 1, if 0 is failed</returns>
        public long Add(TEntity document)
        {
            context.Set<TEntity>().Add(document);
            return context.SaveChanges();
        }

        /// <summary>
        /// Method responsible for update a document of the entity
        /// </summary>
        /// <param name="document">Document being updated</param>
        /// <returns>If you have updated return 1, if 0 is failed</returns>
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

        /// <summary>
        /// Method responsible for delete a document of the entity
        /// </summary>
        /// <param name="id">Document identifier</param>
        /// <returns>Boolean for process of the delete</returns>
        public bool Remove(long id)
        {
            var data = GetById(id);
            if (data != null)
            {
                context.Set<TEntity>().Remove(data);
            }

            return context.SaveChanges() > 0;
        }

        #endregion Methods
    }
}

using System.Collections.Generic;

namespace Domain.Interfaces
{
    /// <summary>
    /// Interface of Repository base of solution
    /// </summary>
    /// <typeparam name="TEntity">Generic entity of solution</typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Method responsible for get all documents of this entity
        /// </summary>
        /// <returns>List of documents of this entity</returns>
        List<TEntity> GetAll();
        /// <summary>
        /// Method responsible for get the document based on your id
        /// </summary>
        /// <param name="id">Entity identifier</param>
        /// <returns>The document based on your entity</returns>
        TEntity GetById(long id);
        /// <summary>
        /// Method responsible for add a new document of the entity
        /// </summary>
        /// <param name="document">Document being added</param>
        /// <returns>If you have added return 1, if 0 is failed</returns>
        long Add(TEntity document);
        /// <summary>
        /// Method responsible for update a document of the entity
        /// </summary>
        /// <param name="document">Document being updated</param>
        /// <returns>If you have updated return 1, if 0 is failed</returns>
        long Update(TEntity document);
        /// <summary>
        /// Method responsible for delete a document of the entity
        /// </summary>
        /// <param name="id">Document identifier</param>
        /// <returns>Boolean for process of the delete</returns>
        bool Remove(long id);
    }
}

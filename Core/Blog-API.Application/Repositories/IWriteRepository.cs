using Blog_API.Domain.Entities.Common;

namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// The IWriteRepository, a generic data access interface (repository), defines functions for writing data
    /// </summary>
    /// <typeparam name="T">The class type representing database entities</typeparam>
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Adds the specified entity to the database
        /// </summary>
        /// <param name="entity">The added entity</param>
        /// <returns>True if the entity is successfully added, false otherwise</returns>
        Task<bool> AddAsync(T entity);
        /// <summary>
        /// Adds a collection of specified entities of the database
        /// </summary>
        /// <param name="entities">The collection of the entities to be added</param>
        /// <returns>True if all entities are sucessfully added, false otherwise</returns>
        Task<bool> AddRangeAsync(List<T> entities);
        /// <summary>
        /// Removes the specified entity from the datbase
        /// </summary>
        /// <param name="entity">The removed entity</param>
        /// <returns>True if the entity is successfully removed, false otherwise</returns>
        bool Remove(T entity);
        /// <summary>
        /// Removes an entity from the database with the specified identifier (ID)
        /// </summary>
        /// <param name="id">The identifier (ID) of the entity to be removed</param>
        /// <returns>True if the entity is successfully removed, false otherwise</returns>
        Task<bool> RemoveAsync(double id);
        /// <summary>
        /// Removes a collection of specified entities from the database
        /// </summary>
        /// <param name="entities">The collection of entities to be removed</param>
        /// <returns>True if all entities are successfully removed, false otherwise</returns>
        bool RemoveRange(List<T> entities);
        /// <summary>
        /// Updates the specified entity in the database
        /// </summary>
        /// <param name="entity">The updated entity</param>
        /// <returns>True if the entity is successfully updated, false otherwise</returns>
        bool Update(T entity);
        /// <summary>
        /// Saves the changes to the database and returns the number of affected rows
        /// </summary>
        /// <returns>The number of changes saved</returns>
        Task<int> SaveAsync();
    }
}

using Blog_API.Domain.Entities.Common;
using System.Linq.Expressions;

namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// The IReadRepository is a generic data access interface (repository) that defines functions for reading data
    /// </summary>
    /// <typeparam name="T">The class type representing database entities</typeparam>
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Retrives all entities from the database
        /// </summary>
        /// <param name="tracking">Specifies whether change tracking is enabled (defualt is true)</param>
        /// <returns>An IQueryable containing all entities</returns>
        IQueryable<T> GetAll(bool tracking = true);
        /// <summary>
        /// Retrivies entities from the database based on a specified filter condition
        /// </summary>
        /// <param name="method">The filter condition as a lambda expression</param>
        /// <param name="tracking">Specifies whether change tracking is enabled (default ture)</param>
        /// <returns>An IQueryable containing the filtered entities</returns>
        IQueryable<T> GetWhere(Expression<Func<T,bool>> method, bool tracking = true);
        /// <summary>
        /// Asynchronously retrivies a single entity from the database based on a specified filter condition
        /// </summary>
        /// <param name="method">The filter condition as a lambda expression</param>
        /// <param name="tracking">Specifies whether change tracking is enabled (default true)</param>
        /// <returns>A task that represents the asynchronous operation and returns the matching entity</returns>
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method,bool tracking = true);
        /// <summary>
        /// Asynchronously retrivies an entity by its unique identifier (ID) from the database
        /// </summary>
        /// <param name="id">The unique identifier (ID) of the entity to retrieve</param>
        /// <param name="tracking">Specifies whether change tracking is enabled (default true)</param>
        /// <returns>A task that represents the asynchronous operation and retuns the matching entity</returns>
        Task<T> GetByIdAsync(double id, bool tracking = true);
    }
}

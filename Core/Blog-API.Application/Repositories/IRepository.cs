using Blog_API.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// IRepository represents a generic data access interface. This interface is used for managing objects derived from BaseEntity
    /// </summary>
    /// <typeparam name="T">The class type representing database entities</typeparam>
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Property representing a DbSet object in the database
        /// </summary>
        public DbSet<T> Table { get; }
    }
}

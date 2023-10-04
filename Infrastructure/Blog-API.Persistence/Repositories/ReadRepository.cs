using Blog_API.Application.Repositories;
using Blog_API.Domain.Entities.Common;
using Blog_API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class represents a generic read repository that implements the IReadRepository interface
    /// </summary>
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        public ReadRepository(ApplicationDbContext context) =>  _context = context;
        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll(bool tracking = true)
        {
            //Create an IQueryable representing the DbSet for the specified entity type
            var query = Table.AsQueryable();

            // If tracking is set to false, configure the query to not track changes
            if (!tracking)
                query = query.AsNoTracking();
            
            // Return the configured IQueryable
            return query;
        }

        public async Task<T> GetByIdAsync(double id, bool tracking = true)
        {

            //Create an IQueryable representing the DbSet for the specified entity type
            var query = Table.AsQueryable();

            // If tracking is set to false, configure the query to not track changes
            if (!tracking)
                query = query.AsNoTracking();

            // Asynchronously find and return the first entity with the specified Id using the configured query
            return await query.FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            // Create an IQueryable representing the DbSet for the specified entity type 
            var query = Table.AsQueryable();

            // If tracking is set to false, configure the query to not track changes
            if (!tracking)
                query = query.AsNoTracking();

            // Asynchronously find and return the first entity that satisfied the specified criteria the configured query
            return await query.FirstOrDefaultAsync(method);

        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            // Create a query by filtering the DbSet based on the specified criteria
            var query = Table.Where(method);

            // If tracking is set to false, configure the query to not track changes
            if (!tracking)
                query = query.AsNoTracking();

            // Return the configured IQueryable containing entities that satisfy the specified criteria
            return query;
        }
    }
}

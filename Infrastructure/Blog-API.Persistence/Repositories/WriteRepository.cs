using Blog_API.Application.Repositories;
using Blog_API.Domain.Entities.Common;
using Blog_API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class represents a basic write (add, update and delete) repository class
    /// </summary>
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public WriteRepository(ApplicationDbContext context) => _context = context;

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            // Add the given entity to the DbSet asynchronously
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);

            // Check if the entity's state is set to Added after the addition
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> entities)
        {
            // Add the list of entities to the DbSet asynchronously
            await Table.AddRangeAsync(entities);

            //Since the addition operation is asynchronously and does not return any status, we assume that the addition is successfull and return true
            return true;
        }

        public bool Remove(T entity)
        {
            //Remove the specified entity from the DbSet
            EntityEntry<T> entityEntry = Table.Remove(entity);

            // Check if the entity's state is set to Deleted after the removal
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(double id)
        {
            // Find the entity with the specified unique identifier asynchronously
            T entity = await Table.FirstOrDefaultAsync(data => data.Id == id);

            // Call the Remove method to remove found entity from the table
            return Remove(entity);
        }

        public bool RemoveRange(List<T> entities)
        {
            // Remove the list of entities from the DbSet
            Table.RemoveRange(entities);

            // Since the removal operation is assumed to be successfull does not we return to indicate that the operation is complete
            return true;
        }

        // This asynchronous method save changes made to the database asynchronously
        public async Task<int> SaveAsync()  =>  await _context.SaveChangesAsync();

        public bool Update(T entity)
        {
            // Update the specified entity in the DbSet
            EntityEntry entityEntry = Table.Update(entity);
            
            // Check if the entity's state is set to Modified after the update
            return entityEntry.State == EntityState.Modified;
        }
    }
}

using Blog_API.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Blog_API.Persistence.Contexts
{
    /// <summary>
    /// Application Context class that manages interaction with the database using Entity Framework
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Constructs a new instance configured with DbContextOptions
        /// </summary>
        /// <param name="options">DbContextOptions object</param>
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        /// <summary>
        /// Used to configure the model using Fluent API
        /// </summary>
        /// <param name="modelBuilder">ModeBuilder object</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        /// <summary>
        /// A method that updates the CreatedDate and UpdatedDate properties of BaseEntity objects while saving changes to the database
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>A Task object representing the number of changes saved</returns>
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // Track all changes in the database context
            var datas = ChangeTracker.Entries<BaseEntity>();
            
            foreach (var data in datas)
            {
                // Update the CreatedDate and UpdatedDate properties based on EntityState
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            // Save changes to the database and return the number of changes saved
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}

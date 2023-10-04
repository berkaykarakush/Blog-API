using Blog_API.Persistence.Configurations;
using Blog_API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Blog_API.Persistence
{
    /// <summary>
    /// This class is responsible for creating an instance if the ApplicationDbContext during desing time
    /// </summary>
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        /// <summary>
        /// Creates a new instance of the ApplicationDbContext for design-time operations
        /// </summary>
        /// <param name="args">Commend-line arguments provided when running design-time tools</param>
        /// <returns>A new ApplicationDbContext instance configured with the specified options</returns>
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Create a new instance of DbContextOptionsBuilder for ApplicationDbContext
            DbContextOptionsBuilder<ApplicationDbContext> dbContextOptionsBuilder = new();
            
            // Configure the builder to use the PostgreSQL connection string from the configuration
            dbContextOptionsBuilder.UseNpgsql(Configuration._configuration.GetSection("ConnectionStrings:PostgreSQL").Value);

            // Return a new ApplicationDbContext instance with the configured options
            return new(dbContextOptionsBuilder.Options);
        }
    }
}

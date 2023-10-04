using Blog_API.Application.Abstractions.Services;
using Blog_API.Application.Repositories;
using Blog_API.Persistence.Configurations;
using Blog_API.Persistence.Contexts;
using Blog_API.Persistence.Repositories;
using Blog_API.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Blog_API.Persistence
{
    /// <summary>
    /// A static class for registering application-specific services with the dependency injection container
    /// </summary>
    public static class ServiceRegistration
    {
        /// <summary>
        ///  Adds application to the IServiceCollection for dependency injection 
        /// </summary>
        /// <param name="serviceCollection">The IServiceCollection to which services are added</param>
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            // Add the ApplicationDbContext to the service collection, configuring it to use the PostgreSQL connection string specified in the application configuration
            serviceCollection.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(Configuration._configuration.GetSection("ConnectionStrings:PostgreSQL").Value));

            // Registering various repositories as scoped services
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

            // Registering various services as scoped services
            serviceCollection.AddScoped<IArticleService, ArticleService>();
            serviceCollection.AddScoped<IArticleImageFileService, ArticleImageFileService>();
            serviceCollection.AddScoped<ICommentService, CommentService>();
            serviceCollection.AddScoped<IFileService, FileService>();
            serviceCollection.AddScoped<ITagService, TagService>();

        }
    }
}

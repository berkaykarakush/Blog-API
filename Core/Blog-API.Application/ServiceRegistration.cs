using Microsoft.Extensions.DependencyInjection;

namespace Blog_API.Application
{
    /// <summary>
    /// A static class for registering application-specific services with the dependency injection container
    /// </summary>
    public static class ServiceRegistration
    {
        /// <summary>
        /// Adds application to the IServiceCollection for dependency injection 
        /// </summary>
        /// <param name="serviceCollection">The IServiceCollection to which services are added</param>
        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {

        }
    }
}

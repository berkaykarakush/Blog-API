using Microsoft.Extensions.Configuration;

namespace Blog_API.Persistence.Configurations
{
    /// <summary>
    /// This static class is used for managing application configure settings
    /// </summary>
    public static class Configuration
    {
        // Static field to store an instance of IConfiguration
        public static IConfiguration _configuration;

        // Method to set the connection string in the configuration
        public static void ConnectionString(IConfiguration configuration)   =>  _configuration = configuration;
    }
}

using System.IO;

using Microsoft.Extensions.Configuration;

namespace KTour.Agency
{
    /// <summary>
    /// Configuration class providing uniform access over configuration files.
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// The configuration root.
        /// </summary>
        private static IConfigurationRoot _configurationRoot;

        /// <summary>
        /// C-tor.
        /// </summary>
        static Configuration()
        {
            // setup configuration builder
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();
        }

        /// <summary>
        /// Retrieves a configuration value for the specified key.
        /// </summary>
        /// <param name="configurationKey">The key to match.</param>
        /// <returns>A value, or NULL if the key was not found.</returns>
        public static string GetConfigurationValue(string configurationKey)
        {
            return _configurationRoot[configurationKey];
        }
    }
}

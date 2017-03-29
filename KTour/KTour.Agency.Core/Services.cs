using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Microsoft.DotNet.InternalAbstractions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;
using Microsoft.Extensions.Logging;

namespace KTour.Agency
{
    /// <summary>
    /// Global injection container manager.
    /// </summary>
    public class Services
    {
        /// <summary>
        /// Service provider used for implementing service locater pattern.
        /// </summary>
        private static IServiceProvider _serviceProvider;

        /// <summary>
        /// Static constructor, initializes metabase of injectable services automatically.
        /// </summary>
        static Services()
        {
            // setup DI and build the service provider.
            _serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddInjectableServices(GetInjectableServices())
                .BuildServiceProvider();

            // create and add console to logger factory.
            var logger = _serviceProvider.GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug)
                .CreateLogger<Services>();

            logger.LogInformation("Successfully setup DI ...");
        }

        /// <summary>
        /// Request service by type from service collection. 
        /// </summary>
        /// <typeparam name="T">The type of the requested service.</typeparam>
        /// <returns>Returns an instance of the requested service.</returns>
        public static T GetService<T>()
        {
            return _serviceProvider.GetService<T>();
        }

        #region helper methods

        /// <summary>
        /// Get the collection of standard assemblies.
        /// </summary>
        /// <returns>The collection of loaded standard assemblies.</returns>
        private static IEnumerable<Assembly> GetStandardAssemblies()
        {
            var runtimeId = RuntimeEnvironment.GetRuntimeIdentifier();
            var assemblyNames = DependencyContext.Default.GetRuntimeAssemblyNames(runtimeId);

            var assemblies = from assemblyName in assemblyNames
                             where assemblyName.FullName.StartsWith("KTour")
                             select Assembly.Load(assemblyName);

            return assemblies.ToList();
        }

        /// <summary>
        /// Discover advertised injectable services searching through the collection of standard assemblies.
        /// </summary>
        /// <returns>
        /// The collection of injectable services structured as key value pairs.
        /// Each element of the collection consists of a service type as the key 
        /// and an implementation type as the value.
        /// </returns>
        private static IEnumerable<KeyValuePair<Type, Type>> GetInjectableServices()
        {
            var injectablePairs = from assembly in GetStandardAssemblies()
                                  from implemenationType in assembly.GetTypes()
                                  where ImplementsAttribute.Any(implemenationType)
                                  let attribute = ImplementsAttribute.Get(implemenationType)
                                  let serviceType = attribute.Type
                                  select new KeyValuePair<Type, Type>(serviceType, implemenationType);

            return injectablePairs.ToList();
        }

        #endregion
    }
}

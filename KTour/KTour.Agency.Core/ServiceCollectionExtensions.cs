using System;
using System.Collections.Generic;

using Microsoft.Extensions.DependencyInjection;

namespace KTour.Agency
{
    /// <summary>
    /// Extension methods for setting up advertised injectable services in an <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register advertised injectable services in an <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="serviceCollection">The <see cref="IServiceCollection"/> to add services to.</param>
        /// <param name="injectableServices">The collection of injectable services.</param>
        /// <returns>The instance of the <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddInjectableServices(this IServiceCollection serviceCollection, IEnumerable<KeyValuePair<Type, Type>> injectableServices)
        {
            foreach (var injectableService in injectableServices)
                serviceCollection.AddTransient(injectableService.Key, injectableService.Value);

            return serviceCollection;
        }
    }
}

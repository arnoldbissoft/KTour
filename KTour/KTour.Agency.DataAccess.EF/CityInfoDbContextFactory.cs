using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace KTour.Agency.DataAccess.EF
{
    /// <summary>
    /// Database context provider factory implementation.
    /// </summary>
    [Implements(typeof(ICityInfoDbContextFactory))]
    public class CityInfoDbContextFactory : IDbContextFactory<CityInfoDbContext>, ICityInfoDbContextFactory
    {
        /// <summary>
        /// Create a new instance of a <see cref="CityInfoDbContext"/>.
        /// </summary>
        /// <param name="options">Database context factory options.</param>
        /// <returns>A new instance of a <see cref="CityInfoDbContext"/>.</returns>
        public CityInfoDbContext Create(DbContextFactoryOptions options)
        {
            return Create();
        }

        /// <summary>
        /// Create a new instance of a <see cref="CityInfoDbContext"/>.
        /// </summary>
        /// <returns>A new instance of a <see cref="CityInfoDbContext"/>.</returns>
        public CityInfoDbContext Create()
        {
            var builder = new DbContextOptionsBuilder<CityInfoDbContext>()
                .UseSqlServer(Configuration.GetConfigurationValue("connectionStrings:cityInfoDbContext"));

            return new CityInfoDbContext(builder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;

using KTour.Agency.DataAccess.EF.Models;

namespace KTour.Agency.DataAccess.EF
{
    /// <summary>
    /// Database context for city info related entities.
    /// </summary>
    public class CityInfoDbContext : DbContext
    {
        /// <summary>
        /// C-tor.
        /// </summary>
        /// <param name="options">The options to be used to build the context.</param>
        public CityInfoDbContext(DbContextOptions<CityInfoDbContext> options)
            : base(options)
        {
            // Ensure DB migration.
            Database.Migrate();
        }

        /// <summary>
        /// Get or set the collection of cities.
        /// </summary>
        public DbSet<City> Cities { get; set; }

        /// <summary>
        /// Get or set the collection of points of interest.
        /// </summary>
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
    }
}

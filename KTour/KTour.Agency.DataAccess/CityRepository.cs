using System.Collections.Generic;
using System.Linq;

using KTour.Agency.Models;
using KTour.Agency.DataAccess.EF;

using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace KTour.Agency.DataAccess
{
    /// <summary>
    /// Repository implementing main operations related to data access for city entities.
    /// </summary>
    [Implements(typeof(ICity))]
    public class CityRepository : ICity
    {
        /// <summary>
        /// The city info db context provider factory.
        /// </summary>
        private readonly ICityInfoDbContextFactory _dbContextFactory;

        /// <summary>
        /// C-tor.
        /// </summary>
        /// <param name="dbContextFactory">The city info db context provider factory.</param>
        public CityRepository(ICityInfoDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        /// <summary>
        /// Check whether a city exists or not in the system based on the city identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <returns>Returns true in case the city exists.</returns>
        public bool CityExists(int cityId)
        {
            using (var dbContext = _dbContextFactory.Create())
            {
                return dbContext.Cities
                            .Any(p => p.Id == cityId);
            }
        }

        /// <summary>
        /// Get the collection of cities.
        /// </summary>
        /// <returns>Returns the collection of existing cities.</returns>
        public IEnumerable<City> GetCities()
        {
            using (var dbContext = _dbContextFactory.Create())
            {
                return dbContext.Cities
                        .ProjectTo<City>()
                        .ToList();
            }
        }

        /// <summary>
        /// Get a specific city based on city identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <param name="includePointOfInterests">Specify whether to load or not the points of interest of the targeted city.</param>
        /// <returns>Returns the matching city entity.</returns>
        public City GetCity(int cityId, bool includePointOfInterests)
        {
            using (var dbContext = _dbContextFactory.Create())
            {
                if (includePointOfInterests)
                    return dbContext.Cities
                                .Include(p => p.PointsOfInterst)
                                .Where(p => p.Id == cityId)
                                .ProjectTo<City>()
                                .FirstOrDefault();


                return dbContext.Cities
                            .Where(p => p.Id == cityId)
                            .ProjectTo<City>()
                            .FirstOrDefault();
            }
        }
    }
}

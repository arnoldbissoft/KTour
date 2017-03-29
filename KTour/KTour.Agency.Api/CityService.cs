using System.Collections.Generic;

using KTour.Agency.Models;

namespace KTour.Agency.Api
{
    /// <summary>
    /// Service implementing main operations related city entities.
    /// </summary>
    [Implements(typeof(ICity))]
    public class CityService : ICity
    {
        /// <summary>
        /// City repository ensuring the data access for city entities data manipulation.
        /// </summary>
        private readonly DataAccess.ICity _cityRepository;

        /// <summary>
        /// C-tor.
        /// </summary>
        /// <param name="cityRepository">The city repository.</param>
        public CityService(DataAccess.ICity cityRepository)
        {
            _cityRepository = cityRepository;
        }

        /// <summary>
        /// Check whether a city exists or not in the system based on the city identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <returns>Returns true in case the city exists.</returns>
        public bool CityExists(int cityId)
        {
            return _cityRepository.CityExists(cityId);
        }

        /// <summary>
        /// Get the collection of cities.
        /// </summary>
        /// <returns>Returns the collection of existing cities.</returns>
        public IEnumerable<City> GetCities()
        {
            return _cityRepository.GetCities();
        }

        /// <summary>
        /// Get a specific city based on city identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <param name="includePointOfInterests">Specify whether to load or not the points of interest of the targeted city.</param>
        /// <returns>Returns the matching city entity.</returns>
        public City GetCity(int cityId, bool includePointOfInterests)
        {
            return _cityRepository.GetCity(cityId, includePointOfInterests);
        }
    }
}

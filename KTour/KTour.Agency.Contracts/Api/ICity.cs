using System.Collections.Generic;

using KTour.Agency.Models;

namespace KTour.Agency.Api
{
    /// <summary>
    /// Contract exposing main APIs related cities data manipulation.
    /// </summary>
    public interface ICity
    {
        /// <summary>
        /// Check whether a city exists or not in the system based on the city identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <returns>Returns true in case the city exists.</returns>
        bool CityExists(int cityId);

        /// <summary>
        /// Get the collection of cities.
        /// </summary>
        /// <returns>Returns the collection of existing cities.</returns>
        IEnumerable<City> GetCities();

        /// <summary>
        /// Get a specific city based on city identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <param name="includePointOfInterests">Specify whether to load or not the points of interest of the targeted city.</param>
        /// <returns>Returns the matching city entity.</returns>
        City GetCity(int cityId, bool includePointOfInterests);
    }
}

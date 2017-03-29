using System.Collections.Generic;

using KTour.Agency.Models;

namespace KTour.Agency.DataAccess
{
    /// <summary>
    /// Contract exposing main data access operations related to point of interest entities.
    /// </summary>
    public interface IPointOfInterest
    {
        /// <summary>
        /// Check whether a point of interest exists or not in the system based on the point of interest identifier.
        /// </summary>
        /// <param name="pointOfInterestId">The point of interest identifier.</param>
        /// <returns>Returns true in case the point of interest exists.</returns>
        bool PointOfInterestExists(int pointOfInterestId);

        /// <summary>
        /// Get the collection of points of interests which belongs to a city.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <returns>Returns a collection of points of interests.</returns>
        IEnumerable<PointOfInterest> GetPointsOfInterest(int cityId);

        /// <summary>
        /// Get a specific point of interest based on its city and it's own identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <param name="pointOfInterestId">The point of interest identifier.</param>
        /// <returns>Returns the matching point of interest entity.</returns>
        PointOfInterest GetPointOfInterest(int cityId, int pointOfInterestId);

        /// <summary>
        /// Add a new point of interest to a specific city.
        /// </summary>
        /// <param name="cityId">Specify the city by it's identifier.</param>
        /// <param name="pointOfInterest">The point of interest entity to be added.</param>
        void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);

        /// <summary>
        /// Update a point of interest entity in the system.
        /// </summary>
        /// <param name="pointOfInterest">The point of interest entity to be updated.</param>
        void UpdatePointOfInterest(PointOfInterest pointOfInterest);

        /// <summary>
        /// Delete a specific point of interest entity from the system.
        /// </summary>
        /// <param name="pointOfInterest">The point of interest entity to be deleted.</param>
        void DeletePointOfInterest(PointOfInterest pointOfInterest);
    }
}

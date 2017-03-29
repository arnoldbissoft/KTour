using System.Collections.Generic;

using KTour.Agency.Models;
using KTour.Agency.DataAccess.EF;

namespace KTour.Agency.DataAccess
{
    /// <summary>
    /// Repository implementing main operations related to data access for point of interest entities.
    /// </summary>
    [Implements(typeof(IPointOfInterest))]
    public class PointOfInterestRepository : IPointOfInterest
    {
        /// <summary>
        /// C-tor.
        /// </summary>
        /// <param name="dbContextFactory">The city info db context provider factory.</param>
        public PointOfInterestRepository(ICityInfoDbContextFactory cityInfoDbContextFactory)
        {
        }

        /// <summary>
        /// Add a new point of interest to a specific city.
        /// </summary>
        /// <param name="cityId">Specify the city by it's identifier.</param>
        /// <param name="pointOfInterest">The point of interest entity to be added.</param>
        public void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest)
        {
        }

        /// <summary>
        /// Delete a specific point of interest entity from the system.
        /// </summary>
        /// <param name="pointOfInterest">The point of interest entity to be deleted.</param>
        public void DeletePointOfInterest(PointOfInterest pointOfInterest)
        {
        }

        /// <summary>
        /// Get a specific point of interest based on its city and it's own identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <param name="pointOfInterestId">The point of interest identifier.</param>
        /// <returns>Returns the matching point of interest entity.</returns>
        public PointOfInterest GetPointOfInterest(int cityId, int pointOfInterestId)
        {
            return null;
        }

        /// <summary>
        /// Get the collection of points of interests which belongs to a city.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <returns>Returns a collection of points of interests.</returns>
        public IEnumerable<PointOfInterest> GetPointsOfInterest(int cityId)
        {
            return new List<PointOfInterest>();
        }

        /// <summary>
        /// Check whether a point of interest exists or not in the system based on the point of interest identifier.
        /// </summary>
        /// <param name="pointOfInterestId">The point of interest identifier.</param>
        /// <returns>Returns true in case the point of interest exists.</returns>
        public bool PointOfInterestExists(int pointOfInterestId)
        {
            return false;
        }

        /// <summary>
        /// Update a point of interest entity in the system.
        /// </summary>
        /// <param name="pointOfInterest">The point of interest entity to be updated.</param>s
        public void UpdatePointOfInterest(PointOfInterest pointOfInterest)
        {
        }
    }
}

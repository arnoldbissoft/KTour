using System.Collections.Generic;
using System.Linq;

namespace KTour.Agency.Models
{
    /// <summary>
    /// The entity describing a city along with it's points of interest.
    /// </summary>
    public class City
    {
        /// <summary>
        /// The city identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The complete name of the city.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The short description of the city.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of points of interests for the current city instance.
        /// </summary>
        public int NumerOfPointsOfInterest => PointsOfInterst.Count();

        /// <summary>
        /// The collection of points of interest for the current city instance.
        /// </summary>
        public ICollection<PointOfInterest> PointsOfInterst { get; set; }
            = new List<PointOfInterest>();
    }
}

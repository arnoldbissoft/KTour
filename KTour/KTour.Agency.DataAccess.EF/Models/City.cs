using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTour.Agency.DataAccess.EF.Models
{
    /// <summary>
    /// The entity describing a city along with it's points of interest.
    /// </summary>
    public class City
    {
        /// <summary>
        /// The city identifier.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// The complete name of the city.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// The short description of the city.
        /// </summary>
        [MaxLength(200)]
        public string Description { get; set; }

        /// <summary>
        /// The collection of points of interest for the current city instance.
        /// </summary>
        public ICollection<PointOfInterest> PointsOfInterst { get; set; }
            = new List<PointOfInterest>();
    }
}

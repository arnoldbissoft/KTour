using System.ComponentModel.DataAnnotations;

namespace KTour.Agency.Models
{
    /// <summary>
    /// The entity describing a point of interest which belongs to a specific city.
    /// </summary>
    public class PointOfInterest
    {
        /// <summary>
        /// The identifier of the point of interest.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the point of interest.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// A short description of the point of interest.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTour.Agency.DataAccess.EF.Models
{
    /// <summary>
    /// The entity describing a point of interest which belongs to a specific city.
    /// </summary>
    public class PointOfInterest
    {
        /// <summary>
        /// The identifier of the point of interest.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [MaxLength(200)]
        public string Description { get; set; }

        /// <summary>
        /// A classification or ranking of the point of interest.
        /// </summary>
        [Range(0, 10)]
        public decimal Rating { get; set; }

        /// <summary>
        /// The city to which this point of interest is related to.
        /// </summary>
        [ForeignKey("CityId")]
        public City City { get; set; }

        /// <summary>
        /// The city identifier to which this point of interest is related to.
        /// </summary>
        public int CityId { get; set; }
    }
}

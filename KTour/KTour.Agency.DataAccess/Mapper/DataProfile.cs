using KTour.Agency.Models;

using AutoMapper;

using CityEF = KTour.Agency.DataAccess.EF.Models.City;
using PointOfInterestEF = KTour.Agency.DataAccess.EF.Models.PointOfInterest;

namespace KTour.Agency.DataAccess.Mapper
{
    /// <summary>
    /// Data profile defining mapping rules between entity framework entities and business models.
    /// </summary>
    /// <remarks>
    /// The data profile will define rules for mapping the entities both way.
    /// </remarks>
    public class DataProfile : Profile
    {
        /// <summary>
        /// C-tor.
        /// </summary>
        public DataProfile()
        {
            // Create mappers from POCO/EF entities to business models.
            CreateMap<CityEF, City>();
            CreateMap<PointOfInterestEF, PointOfInterest>();

            // Create mappers from business models to POCO/EF entities.
            CreateMap<City, CityEF>();
            CreateMap<PointOfInterest, PointOfInterestEF>();
        }
    }
}

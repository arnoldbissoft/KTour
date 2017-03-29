namespace KTour.Agency.DataAccess.EF
{
    /// <summary>
    /// City info database context factory contract. 
    /// </summary>
    public interface ICityInfoDbContextFactory
    {
        /// <summary>
        /// Create a new instance of a <see cref="CityInfoDbContext"/>.
        /// </summary>
        /// <returns>A new instance of a <see cref="CityInfoDbContext"/>.</returns>
        CityInfoDbContext Create();
    }
}

using System;

using AutoMapper;
using Microsoft.Extensions.Logging;

namespace KTour.Agency.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // setup AutoMapper
                Mapper.Initialize(config =>
                {
                    config.AddProfile<DataAccess.Mapper.DataProfile>();
                });

                // create logger.
                var logger = Services.GetService<ILoggerFactory>()
                    .CreateLogger<Program>();

                logger.LogInformation("Starting fetching cities ...");

                var cities = Services.GetService<Api.ICity>()
                    .GetCities();

                foreach (var item in cities)
                    logger.LogInformation($"City {item.Name} retrieved with ID {item.Id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex}");
            }
            finally
            {
                Console.WriteLine("Press any key to exit ...");
                Console.ReadKey(true);
            }
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace KTour.Agency.WebApp.Controllers
{
    /// <summary>
    /// The main application controller.
    /// </summary>
    public class AppController : Controller
    {
        /// <summary>
        /// Returns the home page of the application.
        /// </summary>
        /// <returns>The home page of the web application.</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}

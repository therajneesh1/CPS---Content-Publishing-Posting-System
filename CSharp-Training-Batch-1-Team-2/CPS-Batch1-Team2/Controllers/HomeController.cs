using System.Diagnostics;
using CPS_Batch1_Team2.Models;
using Microsoft.AspNetCore.Mvc;
using CPS_Batch1_Team2.Common;

namespace CPS_Batch1_Team2.Controllers
{
    /// <summary>
    /// Class to handle the home page requests.
    /// </summary>
    public class HomeController : Controller
    {
        #region Properties

        /// <summary>
        /// Logger for the HomeController to log information and errors.
        /// </summary>
        private readonly ILogger<HomeController> _logger;
        /// <summary>
        /// Connection string used to connect to the database.
        /// </summary>
        private readonly string _connectionString;
        /// <summary>
        /// Configuration object to access application settings.
        /// </summary>
        private Configuration _configuration;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the HomeController class.
        /// </summary>
        /// <param name="logger">The logger used for logging information and errors.</param>
        /// <param name="configuration">The configuration object to access application settings.</param>
        public HomeController(ILogger<HomeController> logger, Configuration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _connectionString = _configuration.GetDbConnectionString();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Displays the home page.
        /// </summary>
        /// <returns>The view for the home page.</returns>
        public IActionResult Index()
        {
            _logger.LogInformation("CPS_Batch1_Team2.Controllers.HomeController.Index() : Index method executed.");

            return View();
        }

        /// <summary>
        /// Displays the privacy policy page.
        /// </summary>
        /// <returns>The view for the privacy policy.</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Displays the error page with the request ID.
        /// </summary>
        /// <returns>The view for the error page.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion
    }
}

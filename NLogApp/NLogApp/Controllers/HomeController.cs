using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLogApp.Models;
using System.Diagnostics;

namespace NLogApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private ILogger<HomeController> _logger { get; set; }
        public IActionResult Index()
        {
            _logger.LogInformation("Home-Index");

            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Home-Privacy");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogInformation("Home-Error");

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

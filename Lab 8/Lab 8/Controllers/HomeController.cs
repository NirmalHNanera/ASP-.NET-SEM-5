using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab_8.Models;

namespace Lab_8.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("/")]
        [Route("Index")]
        
        public IActionResult Index()
        {
            return View();
        }

        [Route("Privacy")]
        [Route("/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Optional/{id:int?}")]
        public IActionResult Optional(int? id)
        {
            if (id == null)
            {
                return Content("No ID provided");
            }
            return Content($"Provided ID: {id}");
        }
    }
}
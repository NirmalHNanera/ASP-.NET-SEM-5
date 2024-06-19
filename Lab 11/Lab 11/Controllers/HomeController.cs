using Microsoft.AspNetCore.Mvc;
using Lab_11.Models;
using System.Diagnostics;

namespace Lab_11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Resume()
        {
            return View();
        }
        
        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
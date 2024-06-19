using Lab_13.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Lab_13.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostEnvironment;
        private static List<UserFileUploadViewModel> _users = new List<UserFileUploadViewModel>();

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UploadFiles()
        {
            return View(new UserFileUploadViewModel());
        }

        [HttpPost]
        public IActionResult UploadFiles(UserFileUploadViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                foreach (var file in model.Files)
                {
                    if (file.Length > 0)
                    {
                        string filePath = Path.Combine(uploadPath, Path.GetFileName(file.FileName));
                        model.UploadedFiles.Add(new FileDetail
                        {
                            FileName = file.FileName,
                            FilePath = Path.Combine("uploads", Path.GetFileName(file.FileName))
                        });

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }
                }

                _users.Add(new UserFileUploadViewModel
                {
                    Name = model.Name,
                    Number = model.Number,
                    UploadedFiles = model.UploadedFiles
                });

                ViewBag.Message = "Files uploaded successfully!";
                return View(new UserFileUploadViewModel());
            }

            return View(model);
        }


        public IActionResult ShowList()
        {
            return View(_users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

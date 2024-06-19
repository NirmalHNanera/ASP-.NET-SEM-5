using Lab_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_6.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Details()
        {
            var student = new Student
            {
                StudentId = 1,
                Name = "John Doe",
                Department = "Computer Science",
                SemesterSPIs = new List<SemesterSPI>
                {
                    new SemesterSPI { Semester = 1, SPI = 8.5 },
                    new SemesterSPI { Semester = 2, SPI = 8.7 },
                    new SemesterSPI { Semester = 3, SPI = 9.0 },
                    new SemesterSPI { Semester = 4, SPI = 8.9 }
                }
            };

            return View(student);
        }
        public ActionResult DetailsViewBag()
        {
            var student = new Student
            {
                StudentId = 1,
                Name = "John Doe",
                Department = "Computer Science",
                SemesterSPIs = new List<SemesterSPI>
                {
                    new SemesterSPI { Semester = 1, SPI = 8.5 },
                    new SemesterSPI { Semester = 2, SPI = 8.7 },
                    new SemesterSPI { Semester = 3, SPI = 9.0 },
                    new SemesterSPI { Semester = 4, SPI = 8.9 }
                }
            };
            ViewBag.Student = student;
            ViewBag.SemesterSPIs = student.SemesterSPIs;
            
            

            return View();
        }

        public IActionResult Table()
        {
            return View();
        }
    }
}
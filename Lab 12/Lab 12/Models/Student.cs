using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Lab_12.Models
{
    public class Student
    {
        [Required]
        public string StudentName { get; set; }

        [Required]
        public string Branch { get; set; }
        public List<SelectListItem> BranchList { get; set; }

        [Required]
        public string City { get; set; }
        public List<SelectListItem> CityList { get; set; }

        [Required]
        public int Semester { get; set; }

        [Required]
        [Phone]
        public string StudentMobileNo { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Address { get; set; }

        public List<string> Hobbies { get; set; }

        [Required]
        public string Gender { get; set; }
    }

}

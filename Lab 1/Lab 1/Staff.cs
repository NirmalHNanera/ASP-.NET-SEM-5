using System;

namespace Lab_1
{
    class Staff
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }

        public void DisplayHODStaff()
        {
            if (Designation.ToLower() == "hod")
                Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }
}
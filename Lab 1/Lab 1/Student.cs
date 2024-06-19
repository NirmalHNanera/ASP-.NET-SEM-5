using System;

namespace Lab_1
{
    class Student
    {
        public long Enrollment_No { get; set; }
        public string Student_Name { get; set; }
        public int Semester { get; set; }
        public double CPI { get; set; }
        public double SPI { get; set; }

        public Student(long enrollmentNo, string name, int semester, double cpi, double spi)
        {
            Enrollment_No = enrollmentNo;
            Student_Name = name;
            Semester = semester;
            CPI = cpi;
            SPI = spi;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Enrollment No: {Enrollment_No}");
            Console.WriteLine($"Name: {Student_Name}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"CPI: {CPI}");
            Console.WriteLine($"SPI: {SPI}");
        }
    }
}
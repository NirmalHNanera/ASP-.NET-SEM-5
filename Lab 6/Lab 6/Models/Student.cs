namespace Lab_6.Models;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public List<SemesterSPI> SemesterSPIs { get; set; }
}

public class SemesterSPI
{
    public int Semester { get; set; }
    public double SPI { get; set; }
}
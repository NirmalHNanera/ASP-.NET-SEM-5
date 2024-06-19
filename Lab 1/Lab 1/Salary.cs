using System;

namespace Lab_1
{
    class Salary
    {
        private double Basic { get; set; }
        private double TA { get; set; }
        private double DA { get; set; } = 0.1; // Default value
        private double HRA { get; set; } = 0.2; // Default value

        public Salary(double basic, double ta)
        {
            Basic = basic;
            TA = ta;
        }

        public void CalculateSalary()
        {
            double totalSalary = Basic + TA + (Basic * DA) + (Basic * HRA);
            Console.WriteLine($"Total Salary: {totalSalary}");
        }
    }
}
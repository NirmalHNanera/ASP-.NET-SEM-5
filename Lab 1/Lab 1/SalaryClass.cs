using System;

namespace Lab_1
{
    interface Gross
    {
        void Gross_sal();
    }

    class SalaryClass : Gross
    {
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }

        public void Disp_sal()
        {
            Console.WriteLine($"Basic Salary: {basic_sal()}");
        }

        public double basic_sal()
        {
            return HRA + TA + DA;
        }

        public void Gross_sal()
        {
            double grossSalary = basic_sal();
            Console.WriteLine($"Gross Salary: {grossSalary}");
        }
    }

    class Employee : SalaryClass
    {
        public string Name { get; set; }

        public void Disp_sal()
        {
            Console.WriteLine($"Employee Name: {Name}");
            base.Disp_sal();
        }
    }
    
}
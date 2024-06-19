using System;
using Lab_1;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run (1-10) or 0 to exit:");
                Console.WriteLine("1. Candidate");
                Console.WriteLine("2. Staff");
                Console.WriteLine("3. Bank Account");
                Console.WriteLine("4. Student");
                Console.WriteLine("5. Rectangle");
                Console.WriteLine("6. Interest");
                Console.WriteLine("7. Salary");
                Console.WriteLine("8. Distance");
                Console.WriteLine("9. Table");
                Console.WriteLine("10. Salary Class");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        RunCandidateProgram();
                        break;
                    case 2:
                        RunStaffProgram();
                        break;
                    case 3:
                        RunBankAccountProgram();
                        break;
                    case 4:
                        RunStudentProgram();
                        break;
                    case 5:
                        RunRectangleProgram();
                        break;
                    case 6:
                        RunInterestProgram();
                        break;
                    case 7:
                        RunSalaryProgram();
                        break;
                    case 8:
                        RunDistanceProgram();
                        break;
                    case 9:
                        RunTableProgram();
                        break;
                    case 10:
                        RunSalaryClassProgram();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void RunCandidateProgram()
        {
            Candidate candidate = new Candidate();
            candidate.GetCandidateDetails();
            candidate.DisplayCandidateDetails();
        }

        static void RunStaffProgram()
        {
            Staff[] staffs = new Staff[5];
            for (int i = 0; i < 5; i++)
            {
                staffs[i] = new Staff();
                Console.WriteLine($"Enter details for staff {i + 1}:");
                Console.Write("Name: ");
                staffs[i].Name = Console.ReadLine();
                Console.Write("Department: ");
                staffs[i].Department = Console.ReadLine();
                Console.Write("Designation: ");
                staffs[i].Designation = Console.ReadLine();
                Console.Write("Experience: ");
                staffs[i].Experience = Convert.ToInt32(Console.ReadLine());
                Console.Write("Salary: ");
                staffs[i].Salary = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\nStaffs who are HOD:");
            foreach (var staff in staffs)
            {
                staff.DisplayHODStaff();
            }
        }

        static void RunBankAccountProgram()
        {
            BankAccount account = new BankAccount();
            account.GetAccountDetails();
            account.DisplayAccountDetails();
        }

        static void RunStudentProgram()
        {
            Console.WriteLine("Enter student details:");
            Console.Write("Enrollment No: ");
            long enrollmentNo = Convert.ToInt64(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Semester: ");
            int semester = Convert.ToInt32(Console.ReadLine());
            Console.Write("CPI: ");
            double cpi = Convert.ToDouble(Console.ReadLine());
            Console.Write("SPI: ");
            double spi = Convert.ToDouble(Console.ReadLine());

            Student student = new Student(enrollmentNo, name, semester, cpi, spi);
            student.DisplayStudentDetails();
        }

        static void RunRectangleProgram()
        {
            Console.WriteLine("Enter rectangle dimensions:");
            Console.Write("Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, width);
            rectangle.DisplayArea();
        }

        static void RunInterestProgram()
        {
            Interest interest = new Interest();
            Console.Write("Enter Account Balance: ");
            interest.Balance = Convert.ToDouble(Console.ReadLine());
            interest.CalculateInterest();
        }

        static void RunSalaryProgram()
        {
            Console.WriteLine("Enter salary details:");
            Console.Write("Basic Salary: ");
            double basic = Convert.ToDouble(Console.ReadLine());
            Console.Write("TA: ");
            double ta = Convert.ToDouble(Console.ReadLine());

            Salary salary = new Salary(basic, ta);
            salary.CalculateSalary();
        }

        static void RunDistanceProgram()
        {
            Console.WriteLine("Enter distances:");
            Console.Write("Distance 1: ");
            double dist1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Distance 2: ");
            double dist2 = Convert.ToDouble(Console.ReadLine());

            Distance distance = new Distance(dist1, dist2);
            distance.DisplayTotalDistance();
        }

        static void RunTableProgram()
        {
            Table table = new Table();
            Console.WriteLine("Enter table details:");
            Console.Write("Material: ");
            table.Material = Console.ReadLine();
            Console.Write("Price: ");
            table.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            table.Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Surface Area: ");
            table.Surface_Area = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nTable Details:");
            Console.WriteLine($"Material: {table.Material}");
            Console.WriteLine($"Price: {table.Price}");
            Console.WriteLine($"Height: {table.Height}");
            Console.WriteLine($"Surface Area: {table.Surface_Area}");
        }

        static void RunSalaryClassProgram()
        {
            SalaryClass salaryClass = new SalaryClass();
            Console.WriteLine("Enter salary components:");
            Console.Write("HRA: ");
            salaryClass.HRA = Convert.ToDouble(Console.ReadLine());
            Console.Write("TA: ");
            salaryClass.TA = Convert.ToDouble(Console.ReadLine());
            Console.Write("DA: ");
            salaryClass.DA = Convert.ToDouble(Console.ReadLine());
            salaryClass.Disp_sal();
            salaryClass.Gross_sal();
            Employee employee = new Employee();
            Console.WriteLine("Enter employee details:");
            Console.Write("Name: ");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Enter salary components:");
            Console.Write("HRA: ");
            employee.HRA = Convert.ToDouble(Console.ReadLine());
            Console.Write("TA: ");
            employee.TA = Convert.ToDouble(Console.ReadLine());
            Console.Write("DA: ");
            employee.DA = Convert.ToDouble(Console.ReadLine());
            employee.Disp_sal();
            employee.Gross_sal();
        }
    }
}

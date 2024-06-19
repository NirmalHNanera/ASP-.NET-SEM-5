using System;
using Lab3;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run (1-8) or 0 to exit:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. AreaCalculator");
                Console.WriteLine("3. RBI Interest Calculation");
                Console.WriteLine("4. FactorialCalculator");
                Console.WriteLine("5. Hospital Details");
                Console.WriteLine("6. AreaCalculatorOverloading");
                Console.WriteLine("7. TrafficSignal");
                Console.WriteLine("8. Calculator");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        RunAdditionProgram();
                        break;
                    case 2:
                        RunAreaCalculatorProgram();
                        break;
                    case 3:
                        RunRBIProgram();
                        break;
                    case 4:
                        RunFactorialCalculatorProgram();
                        break;
                    case 5:
                        RunHospitalProgram();
                        break;
                    case 6:
                        RunAreaCalculatorOverloadingProgram();
                        break;
                    case 7:
                        RunTrafficSignalProgram();
                        break;
                    case 8:
                        RunCalculatorProgram();
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

        static void RunAdditionProgram()
        {
            Console.Write("Enter first integer: ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition of integers: " + Addition.Add(int1, int2));

            Console.Write("Enter first float: ");
            float float1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter second float: ");
            float float2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Addition of floats: " + Addition.Add(float1, float2));
        }

        static void RunAreaCalculatorProgram()
        {
            Console.Write("Enter side of square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of square: " + AreaCalculator.CalculateArea(side));

            Console.Write("Enter length of rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of rectangle: " + AreaCalculator.CalculateArea(length, width));
        }

        static void RunRBIProgram()
        {
            Console.Write("Enter principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time period: ");
            double time = Convert.ToDouble(Console.ReadLine());

            RBI rbi1 = new HDFC();
            Console.WriteLine("Interest calculated by HDFC: " + rbi1.CalculateInterest(principal, rate, time));

            RBI rbi2 = new SBI();
            Console.WriteLine("Interest calculated by SBI: " + rbi2.CalculateInterest(principal, rate, time));

            RBI rbi3 = new ICICI();
            Console.WriteLine("Interest calculated by ICICI: " + rbi3.CalculateInterest(principal, rate, time));
        }

        static void RunFactorialCalculatorProgram()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            FactorialCalculator.FactorialDelegate factorial = FactorialCalculator.GetFactorial;
            Console.WriteLine("Factorial of " + num + ": " + factorial(num));
        }

        static void RunHospitalProgram()
        {
            Hospital hospital1 = new Apollo();
            hospital1.HospitalDetails();

            Hospital hospital2 = new Wockhardt();
            hospital2.HospitalDetails();

            Hospital hospital3 = new Gokul_Superspeciality();
            hospital3.HospitalDetails();
        }

        static void RunAreaCalculatorOverloadingProgram()
        {
            Console.Write("Enter side of square: ");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square: " + AreaCalculatorOverloading.CalculateArea(side));

            Console.Write("Enter length of rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of rectangle: " + AreaCalculatorOverloading.CalculateArea(length, width));

            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of circle: " + AreaCalculatorOverloading.CalculateArea(radius));
        }

        static void RunTrafficSignalProgram()
        {
            TrafficSignal.TrafficDel trafficDel = TrafficSignal.Green;
            trafficDel += TrafficSignal.Yellow;
            trafficDel += TrafficSignal.Red;
            trafficDel();
        }

        static void RunCalculatorProgram()
        {
            Console.Write("Enter first integer: ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Calculator.CalculatorDelegate<int> calcInt = Calculator.Add;
            Console.WriteLine("Addition result: " + calcInt(int1, int2));

            Console.Write("Enter first double: ");
            double double1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second double: ");
            double double2 = Convert.ToDouble(Console.ReadLine());
            Calculator.CalculatorDelegate<double> calcDouble = Calculator.Subtract;
            Console.WriteLine("Subtraction result: " + calcDouble(double1, double2));
        }
    }
}

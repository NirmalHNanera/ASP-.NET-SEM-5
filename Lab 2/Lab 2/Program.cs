using System;
using Lab2;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run (1-10) or 0 to exit:");
                Console.WriteLine("1. DivideByZeroExceptionDemo");
                Console.WriteLine("2. IndexOutOfRangeDemo");
                Console.WriteLine("3. Calculate Sum");
                Console.WriteLine("4. Result Calculation");
                Console.WriteLine("5. StringMethodsDemo");
                Console.WriteLine("6. CaseConversionDemo");
                Console.WriteLine("7. Shape Calculation");
                Console.WriteLine("8. EvenNumberChecker");
                Console.WriteLine("9. LongestWordFinder");
                Console.WriteLine("10. CaseChange");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        DivideByZeroExceptionDemo.Run();
                        break;
                    case 2:
                        IndexOutOfRangeDemo.Run();
                        break;
                    case 3:
                        RunCalculateProgram();
                        break;
                    case 4:
                        RunResultProgram();
                        break;
                    case 5:
                        StringMethodsDemo.Run();
                        break;
                    case 6:
                        CaseConversionDemo.Run();
                        break;
                    case 7:
                        RunShapeProgram();
                        break;
                    case 8:
                        RunEvenNumberCheckerProgram();
                        break;
                    case 9:
                        RunLongestWordFinderProgram();
                        break;
                    case 10:
                        RunCaseChangeProgram();
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

        static void RunCalculateProgram()
        {
            Calculate calc = new Calculate();
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number (or 0 if not needed): ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of 2 numbers: " + calc.SumOfTwo(a, b));
            if (c != 0)
                Console.WriteLine("Sum of 3 numbers: " + calc.SumOfThree(a, b, c));
        }

        static void RunResultProgram()
        {
            Result result = new Result();
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            result.Addition(a, b);
            result.Subtraction(a, b);
        }

        static void RunShapeProgram()
        {
            Shape shape = new Shape();
            Console.WriteLine("Select a shape to calculate area:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Square");
            int shapeChoice = Convert.ToInt32(Console.ReadLine());

            switch (shapeChoice)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of Circle: " + shape.Circle(radius));
                    break;
                case 2:
                    Console.Write("Enter base length: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of Triangle: " + shape.Triangle(baseLength, height));
                    break;
                case 3:
                    Console.Write("Enter side length: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of Square: " + shape.Square(side));
                    break;
                default:
                    Console.WriteLine("Invalid shape choice");
                    break;
            }
        }

        static void RunEvenNumberCheckerProgram()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                EvenNumberChecker.CheckEvenNumber(num);
            }
            catch (EvenNumberException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
        }

        static void RunLongestWordFinderProgram()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string longestWord = LongestWordFinder.FindLongestWord(sentence);
            Console.WriteLine($"Longest word: {longestWord}");
        }

        static void RunCaseChangeProgram()
        {
            Console.Write("Enter a character: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nOriginal character: {ch}");
            char changedChar = CaseChange.ChangeCase(ch);
            Console.WriteLine($"Changed character: {changedChar}");
        }
    }
}

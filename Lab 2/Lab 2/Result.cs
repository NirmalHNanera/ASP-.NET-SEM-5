using System;

namespace Lab2
{
    interface ICalculate
    {
        void Addition(int a, int b);
        void Subtraction(int a, int b);
    }

    class Result : ICalculate
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine($"Addition: {a + b}");
        }

        public void Subtraction(int a, int b)
        {
            Console.WriteLine($"Subtraction: {a - b}");
        }
    }
}
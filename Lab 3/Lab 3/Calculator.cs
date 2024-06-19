using System;

namespace Lab3
{
    class Calculator
    {
        public delegate T CalculatorDelegate<T>(T num1, T num2);

        public static T Add<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a + b;
        }

        public static T Subtract<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a - b;
        }
    }
}
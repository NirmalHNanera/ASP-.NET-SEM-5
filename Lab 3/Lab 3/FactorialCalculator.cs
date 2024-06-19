using System;

namespace Lab3
{
    class FactorialCalculator
    {
        public delegate int FactorialDelegate(int n);

        public static int GetFactorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
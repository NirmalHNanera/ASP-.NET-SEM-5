using System;

namespace Lab2
{
    class EvenNumberException : Exception
    {
        public EvenNumberException(string message) : base(message) { }
    }

    class EvenNumberChecker
    {
        public static void CheckEvenNumber(int num)
        {
            if (num % 2 != 0)
            {
                throw new EvenNumberException("Number is not even.");
            }
            else
            {
                Console.WriteLine("Number is even.");
            }
        }
    }
}
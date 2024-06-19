using System;

namespace Lab2
{
    class DivideByZeroExceptionDemo
    {
        public static void Run()
        {
            try
            {
                int num = 10;
                int result = num / 0; // This will cause DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
        }
    }
}
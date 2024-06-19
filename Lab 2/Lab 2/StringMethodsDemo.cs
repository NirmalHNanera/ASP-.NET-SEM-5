using System;

namespace Lab2
{
    class StringMethodsDemo
    {
        public static void Run()
        {
            string str = "Hello, World!";
            Console.WriteLine($"Length of string: {str.Length}");
            Console.WriteLine($"Substring: {str.Substring(7)}");
            Console.WriteLine($"To upper case: {str.ToUpper()}");
            Console.WriteLine($"To lower case: {str.ToLower()}");
        }
    }
}
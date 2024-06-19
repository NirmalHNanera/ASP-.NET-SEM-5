using System;

namespace Lab2
{
    class CaseConversionDemo
    {
        public static void Run()
        {
            string str = "Hello, World!";
            Console.WriteLine($"Original string: {str}");
            string upperCaseStr = str.ToUpper();
            string lowerCaseStr = str.ToLower();
            Console.WriteLine($"Upper case: {upperCaseStr}");
            Console.WriteLine($"Lower case: {lowerCaseStr}");
        }
    }
}
using System;

namespace Lab2
{
    class IndexOutOfRangeDemo
    {
        public static void Run()
        {
            try
            {
                int[] arr = new int[5];
                for (int i = 0; i <= 5; i++) // Trying to access index 5 which is out of range
                {
                    arr[i] = i;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
        }
    }
}
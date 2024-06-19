using System;

namespace Lab_1
{
    class Account_Details
    {
        public string Account_No { get; set; }
        public double Balance { get; set; }
    }

    class Interest : Account_Details
    {
        public void CalculateInterest()
        {
            double interest = Balance * 0.05; // Example interest rate
            Console.WriteLine($"Interest: {interest}");
        }
    }
}
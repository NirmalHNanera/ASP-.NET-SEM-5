using System;

namespace Lab_1
{
    class BankAccount
    {
        public int Account_No { get; set; }
        public string Email { get; set; }
        public string User_Name { get; set; }
        public string Account_Type { get; set; }
        public double Account_Balance { get; set; }

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter account details:");
            Console.Write("Account No: ");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.Write("User Name: ");
            User_Name = Console.ReadLine();
            Console.Write("Account Type: ");
            Account_Type = Console.ReadLine();
            Console.Write("Account Balance: ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine($"Account No: {Account_No}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"User Name: {User_Name}");
            Console.WriteLine($"Account Type: {Account_Type}");
            Console.WriteLine($"Account Balance: {Account_Balance}");
        }
    }
}
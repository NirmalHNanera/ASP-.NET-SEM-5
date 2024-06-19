using System;

namespace Lab_1
{
    class Candidate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }


        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter candidate details:");
            Console.Write("ID: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Weight: ");
            Weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("\nCandidate Details:");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Height: {Height}");
        }
    }
}
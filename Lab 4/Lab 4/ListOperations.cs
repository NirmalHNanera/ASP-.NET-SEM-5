using System;
using System.Collections.Generic;

namespace Lab4
{
    class ListOperations
    {
        public static void Run()
        {
            List<string> studentList = new List<string>();
            while (true)
            {
                Console.WriteLine("\nList Operations:");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Remove student at index");
                Console.WriteLine("3. Remove students within a range");
                Console.WriteLine("4. Clear all students");
                Console.WriteLine("0. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 4)
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }

                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter student name to add:");
                        string name = Console.ReadLine();
                        studentList.Add(name);
                        break;
                    case 2:
                        Console.WriteLine("Enter index to remove:");
                        int index;
                        if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < studentList.Count)
                        {
                            studentList.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter start index:");
                        int startIndex;
                        Console.WriteLine("Enter count:");
                        int count;
                        if (int.TryParse(Console.ReadLine(), out startIndex) && int.TryParse(Console.ReadLine(), out count)
                            && startIndex >= 0 && startIndex + count <= studentList.Count)
                        {
                            studentList.RemoveRange(startIndex, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid range");
                        }
                        break;
                    case 4:
                        studentList.Clear();
                        break;
                }

                Console.WriteLine("Current students: " + string.Join(", ", studentList));
            }

            Console.WriteLine("List operations completed.");
        }
    }
}

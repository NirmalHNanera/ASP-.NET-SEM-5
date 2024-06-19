using System;
using System.Collections.Generic;

namespace Lab4
{
    class StackOperations
    {
        public static void Run()
        {
            Stack<int> stack = new Stack<int>();
            while (true)
            {
                Console.WriteLine("\nStack Operations:");
                Console.WriteLine("1. Push item");
                Console.WriteLine("2. Pop item");
                Console.WriteLine("3. Peek top item");
                Console.WriteLine("4. Check if an item exists");
                Console.WriteLine("5. Clear stack");
                Console.WriteLine("0. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 5)
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }

                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter item to push:");
                        int item;
                        if (int.TryParse(Console.ReadLine(), out item))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            Console.WriteLine("Invalid item");
                        }
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            int poppedItem = stack.Pop();
                            Console.WriteLine($"Popped item: {poppedItem}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty");
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            int topItem = stack.Peek();
                            Console.WriteLine($"Top item: {topItem}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter item to check:");
                        if (int.TryParse(Console.ReadLine(), out item))
                        {
                            bool containsItem = stack.Contains(item);
                            Console.WriteLine($"Contains {item}: {containsItem}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid item");
                        }
                        break;
                    case 5:
                        stack.Clear();
                        break;
                }

                Console.WriteLine("Current stack: " + string.Join(", ", stack));
            }

            Console.WriteLine("Stack operations completed.");
        }
    }
}

using System;
using System.Collections.Generic;

namespace Lab4
{
    class QueueOperations
    {
        public static void Run()
        {
            Queue<int> queue = new Queue<int>();
            while (true)
            {
                Console.WriteLine("\nQueue Operations:");
                Console.WriteLine("1. Enqueue item");
                Console.WriteLine("2. Dequeue item");
                Console.WriteLine("3. Peek front item");
                Console.WriteLine("4. Check if an item exists");
                Console.WriteLine("5. Clear queue");
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
                        Console.WriteLine("Enter item to enqueue:");
                        int item;
                        if (int.TryParse(Console.ReadLine(), out item))
                        {
                            queue.Enqueue(item);
                        }
                        else
                        {
                            Console.WriteLine("Invalid item");
                        }
                        break;
                    case 2:
                        if (queue.Count > 0)
                        {
                            int dequeuedItem = queue.Dequeue();
                            Console.WriteLine($"Dequeued item: {dequeuedItem}");
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty");
                        }
                        break;
                    case 3:
                        if (queue.Count > 0)
                        {
                            int frontItem = queue.Peek();
                            Console.WriteLine($"Front item: {frontItem}");
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter item to check:");
                        if (int.TryParse(Console.ReadLine(), out item))
                        {
                            bool containsQueueItem = queue.Contains(item);
                            Console.WriteLine($"Contains {item}: {containsQueueItem}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid item");
                        }
                        break;
                    case 5:
                        queue.Clear();
                        break;
                }

                Console.WriteLine("Current queue: " + string.Join(", ", queue));
            }

            Console.WriteLine("Queue operations completed.");
        }
    }
}

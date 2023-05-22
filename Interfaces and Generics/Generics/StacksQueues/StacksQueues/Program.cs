using System;
using System.Collections.Generic;

namespace StacksQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new stack to hold the names of sports
            Stack<string> sportsStack = new Stack<string>();
            // Push some initial items on to the stack
            sportsStack.Push("Baseball");
            sportsStack.Push("Football");
            sportsStack.Push("Cricket");
            sportsStack.Push("Basketball");
            sportsStack.Push("Hockey");
            sportsStack.Push("Rugby");

            // TODO: Let's see how many items are on the stack
            Console.WriteLine("There are {0} sports in the stack",sportsStack.Count);

            // TODO: Peek at the top item
            Console.WriteLine("The top item is {0}",sportsStack.Peek());

            // TODO: Pop 2 items, then try the Contains method
            sportsStack.Pop();
            sportsStack.Pop();
            Console.WriteLine("Stack Contains Hockey: {0}",sportsStack.Contains("Hockey"));
            // Create a queue to hold the names of sports
            Queue<string> sportsQueue = new Queue<string>();
            // Enqueue some initial items on to the stack
            sportsQueue.Enqueue("Baseball");
            sportsQueue.Enqueue("Football");
            sportsQueue.Enqueue("Cricket");
            sportsQueue.Enqueue("Basketball");
            sportsQueue.Enqueue("Hockey");
            sportsQueue.Enqueue("Rugby");

            // TODO: Let's see how many items are on the queue
            Console.WriteLine("There are {0} sports in the queue", sportsQueue.Count);
            // TODO: Peek at the front item
            Console.WriteLine("The top item is {0}", sportsQueue.Peek());

            // TODO: Dequeue 2 items, then try the Contains method
            sportsQueue.Dequeue();
            sportsQueue.Dequeue();
            Console.WriteLine("Queue Contains Hockey: {0}", sportsQueue.Contains("Hockey"));
            // Keep the window open
            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
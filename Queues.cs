using System;
using System.Collections.Generic;

namespace QueuesExample
{
    class Queue
    {
        public static void DisplayQueue(Queue<int> queue)
        {
            //Vereify if the queue is empty

            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            // prin the whole queue
            while (queue.Count > 0)
            {
                // Dequeue the first element
                Console.Write(queue.Dequeue() + " ");
            }
        }

        public static void ReversesQueue(Queue<int> queue)
        {
            // Create a temporary queue for reversing
            Queue<int> tempQueue = new Queue<int>();
            // Check if the queue is empty
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            // Transfer elements from the original queue to the temporary queue
            while (queue.Count > 1)
            {
                // Dequeue the first element and enqueue it to the temporary queue
                tempQueue.Enqueue(queue.Dequeue());
            }
            // Dequeue the last element and print it
            Console.WriteLine(queue.Dequeue());
            // call it recursively to reverse the remaining elements
            ReversesQueue(tempQueue);
        }

        public static void Main(string[] args)
        {
            Queue<int> queue1 = new Queue<int>();
            // Enqueue elements onto the queue
            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);
            queue1.Enqueue(4);
            queue1.Enqueue(5);

            // Display the queue
            Console.WriteLine("Queue elements:");
            DisplayQueue(queue1);

            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);
            queue1.Enqueue(4);
            queue1.Enqueue(5);

            Console.WriteLine("\nReversed Queue elements:");
            // Reverse the queue
            ReversesQueue(queue1);
        }
    }
}
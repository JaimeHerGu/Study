// See https://aka.ms/new-console-template for more information
using System;

namespace StacksExample
{
    class Stack
    {
        public static void FiFoforStack(Stack<int> stack1)
        {
            // Create a second stack to hold elements temporarily
            Stack<int> stack2 = new Stack<int>();
            // Check if both stacks are empty
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("Both stacks are empty.");
                return;
            }
            // move elements from stack1 to stack2 until last element of stack1 is reached
            while (stack1.Count > 1)
            {
                stack2.Push(stack1.Pop());
            }
            // Pop the last element from stack1
            if (stack1.Count > 0)
            {
                Console.WriteLine(stack1.Pop());
            }
            // Move elements back from stack2 to stack1
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }

        }
        public static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            // Push elements onto the stack
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);
            // Display the stack
            FiFoforStack(stack1);
            FiFoforStack(stack1);
            FiFoforStack(stack1);
            FiFoforStack(stack1);
            FiFoforStack(stack1);
            FiFoforStack(stack1);

        }
    }
}

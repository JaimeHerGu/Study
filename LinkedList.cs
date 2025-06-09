using System;

namespace LinkedListExample
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int newData)
        {
            Data = newData;
            Next = null;
        }
    }

    class LinkedList
    {
        static void TrasnversalList(Node head)
        {
            // A lop that runs till head is null
            while (head != null)
            {
                //Print the data of the current node
                Console.Write(head.Data + " ");

                //Move to the next node
                head = head.Next;

            }

            Console.WriteLine();
        }

        static void DeleteNode(Node head, int position)
        {
            Node temp = head;
            Node prev = null;

            // If the linked list is empty or position is invalid
            if (head == null || position < 0)
            {
                return;
            }

            // If the head needs to be removed
            if (position == 0)
            {
                head = head.Next;
                return;
            }

            // Traverse to the node just before the position
            for (int i = 1; i < position && temp != null; i++)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp != null)
            {
                prev.Next = temp.Next; // Unlink the node from the list
            }
            else
            {
                Console.WriteLine("Position is out of bounds.");
            }

            return;
        }

        static void DeleteNodeAtEnd(Node head)
        {
            if (head == null)
            {
                return; // List is empty
            }
            if (head.Next == null)
            {
                head = null; // List has only one node
                return;
            }

            //Find the second last node
            Node secondLast = head;
            while (secondLast.Next.Next != null)
            {
                secondLast = secondLast.Next;
            }
            secondLast.Next = null; // Remove the last node

        }
        public static void Main(string[] args)
        {
            // Create nodes
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(4);
            head.Next.Next.Next.Next = new Node(5);
            head.Next.Next.Next.Next.Next = new Node(6);

            // Traverse the linked list
            TrasnversalList(head);
            // Delete a node at position 2
            DeleteNode(head, 2);
            // Traverse the linked list again
            TrasnversalList(head);
            // Delete the last node
            DeleteNodeAtEnd(head);
            // Traverse the linked list again
            TrasnversalList(head);
        }
    }
}
using LinkedListLibrary;
using LinkedListTests;
using System;

namespace InsertNodeIntoLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static Node InsertNodeIntoLL(Node head, int value, int position)
        {

            Node node = new Node(value);
            Node current = head;

            // if the list is empty, return the node
            if (head == null)
            {
                return node;
            }

            // traverse the list until the node before the insert position
            for (int i = 0; i < position -1; i++)
            {
                current = current.Next;
            }

            // connect the node that will be added to the current.Next, the node before which it will be inserted,
            node.Next = current.Next;
            // assign the current.Next to the Node is being inserted. 
            current.Next = node;

            return head;
        }

    }
}

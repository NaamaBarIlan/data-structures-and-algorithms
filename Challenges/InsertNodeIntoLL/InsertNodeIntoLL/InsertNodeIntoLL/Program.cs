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

        public static Node InsertIntoLL(Node head, int value, int position)
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

        public Node FindAValue(LinkedList list, int inputValue)
        {
            // declare a current and set it to the head of the LL
            Node current = list.Head;

            // traverse the LL, while current isn't null, advance it to current.Next
            while (current != null)
            {
                // if the current value equals the input value, return the current
                if (current.Value == inputValue)
                {
                    return current;
                }

                current = current.Next;
            }

            // if the input value wasn't found return null
            return null;
        }


        public static void TraverseLL(LinkedList list)
        {
            // the public function is calling on the private function, passing through the head of the LL
            TraverseLL(list.Head);
        }

        private static void TraverseLL(Node current)
        {
            // The eval logic, with the current node's value, like adding to a list
            Console.WriteLine(current.Value);

            // the recursion - calling on the same function with current.Next. 
            if (current.Next != null)
            {
                TraverseLL(current.Next);
            }
        }
    }
}

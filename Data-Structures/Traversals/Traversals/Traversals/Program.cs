using LinkedListLibrary;
using LinkedListTests;
using System;
using System.Collections.Generic;

namespace Traversals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traversals");

        }

        //LinkedLists

        //1. Counting the amount of nodes in Linked List

        public static int CountLLNodes(LinkedList linkedList)
        {
            int counter = 0;
            Node current = linkedList.Head;

            while (current != null)
            {
                counter++;
                current = current.Next;
            }

            return counter;
        }


        //2. Counting the amount of duplicated nodes in a Linked List


    }
}

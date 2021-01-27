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

            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            Console.WriteLine(CountLLNodes(list));

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

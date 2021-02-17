using LinkedListLibrary;
using LinkedListTests;
using System;
using System.Collections.Generic;
using Trees;

namespace Traversals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList Traversals");

            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(2);

            Console.WriteLine($"list: {list}");

            Console.WriteLine($"Reverse LL: {ReverseLL(list)}");

            Console.WriteLine($"Reverse LL Recursively: {ReverseLLRec(list)}");

            Console.WriteLine($"Count LL Nodes: {CountLLNodes(list)}");

            Console.WriteLine($"Count LL Nodes Recursively: {CountLLNodesRec(list)}");

            Console.WriteLine($"CountDuplicateLLNodes: {CountDuplicateLLNodes(list)}");

        }

        /// <summary>
        /// Counts the number of nodes in a linked list
        /// </summary>
        /// <param name="linkedList">A specific linked list</param>
        /// <returns>The total number of nodes in the linked list</returns>
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

        /// <summary>
        /// Counts the number of nodes in a linked list recursively
        /// </summary>
        /// <param name="list">A specific linked list</param>
        /// <returns>The total number of nodes in the linked list</returns>
        public static int CountLLNodesRec(LinkedList list)
        {
            return CountLLNodesRecHelper(list.Head); 
        }

        /// <summary>
        /// A helper method for CountNodesRec
        /// </summary>
        /// <param name="current">The head node of the linked list that is being traversed</param>
        /// <returns>The total number of nodes in the linked list</returns>
        private static int CountLLNodesRecHelper(Node current)
        {
            if(current == null)
            {
                return 0;
            }

            return 1 + CountLLNodesRecHelper(current.Next); ;
        }


        //Counting the number of duplicated nodes in a Linked List

        /// <summary>
        /// Counts the number of duplicate nodes in a linked list
        /// </summary>
        /// <param name="list">A given linked list</param>
        /// <returns>The total number of duplicate nodes in the linked list</returns>
        public static int CountDuplicateLLNodes(LinkedList list)
        {
            int counter = 0;
            Node walker = list.Head;
            Node runner = list.Head;

            while (walker.Next != null)
            {
                while (runner.Next != null)
                {
                    runner = runner.Next;

                    if (runner.Value == walker.Value)
                    {
                        counter++;
                    }
                }

                walker = walker.Next;
                runner = walker;
            }

            return counter;
        }

        /// <summary>
        /// Reverses a linked list so that the all of the list's values are in reverse order.
        /// </summary>
        /// <param name="list">The linked list that is being reversed</param>
        /// <returns>A new linked list with all of the values 
        /// of the original linked list in reverse order</returns>
        public static LinkedList ReverseLL(LinkedList list)
        {
            LinkedList newList = new LinkedList();

            Node current = list.Head;

            if (current == null)
            {
                return null;
            }

            while (current != null)
            {
                newList.Insert(current.Value);
                current = current.Next;
            }

            return newList;
        }

        /// <summary>
        /// Recursively reverses a linked list so that the all of the list's values are in reverse order.
        /// </summary>
        /// <param name="list">The linked list that is being reversed</param>
        /// <returns>A new linked list with all of the values 
        /// of the original linked list in reverse order</returns>
        public static LinkedList ReverseLLRec(LinkedList list)
        {
            LinkedList newList = new LinkedList();
            ReverseLLRecHelper(list.Head, newList);
            return newList;
        }

        /// <summary>
        /// A helper method for the ReverseLLRec method,
        /// handles the recursion. 
        /// </summary>
        /// <param name="current">The head node of the LinkedList that is being traversed</param>
        /// <param name="newList">An empty LinkedList</param>
        /// <returns>The newList with all of the node values of the traversed list, 
        /// in reverse order</returns>
        private static LinkedList ReverseLLRecHelper(Node current, LinkedList newList)
        {
            if (current == null)
            {
                return newList;
            }

            newList.Insert(current.Value);

            ReverseLLRecHelper(current.Next, newList);

            return newList;
        }
    }
}

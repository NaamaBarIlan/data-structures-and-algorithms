﻿using LinkedListLibrary;
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

            Console.WriteLine("Linked Lists:");

            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(4);
            list.Insert(8);

            //Console.WriteLine(CountLLNodes(list));

            Console.WriteLine(CountDuplicateLLNodes(list));

        }

        //LinkedLists

        //Counting the amount of nodes in Linked List

        /// <summary>
        /// Counts the number of nodes in a linked list
        /// </summary>
        /// <param name="linkedList">A specific linked list</param>
        /// <returns>The number of nodes in the linked list</returns>
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


        //Counting the amount of duplicated nodes in a Linked List

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


    }
}

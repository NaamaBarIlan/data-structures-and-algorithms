using System;
using System.Collections.Generic;

namespace RemoveDupesFromLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			LinkedList<int> list1 = new LinkedList<int>();
			list1.AddLast(1);
			list1.AddLast(1);
			list1.AddLast(3);
			list1.AddLast(4);
			list1.AddLast(4);
			list1.AddLast(4);
			list1.AddLast(5);
			list1.AddLast(6);
			list1.AddLast(6);

            Console.WriteLine(RemoveDuplicatesFromLinkedList(list1)); 

		}

		public static LinkedList<int> RemoveDuplicatesFromLinkedList(LinkedList<int> linkedList)
		{
			// set up current and runner to list's Head
			
			LinkedListNode<int> current = linkedList.First;
			LinkedListNode<int> runner = linkedList.First;

			// check if list is empty => return null
			if (current == null)
			{
				return null;
			}

			// move runner to runner.Next
			runner = runner.Next;

			// traverse both runner and current. 
			while (current.Next != null)
			{
				// if current equals runner
				// move runner to runner.Next and delete runner.
				 while (current.Value == runner.Value)
				{
					LinkedListNode<int> temp = current.Next;
					runner = runner.Next;
				}

				current = runner;
				runner = runner.Next;

			}

			return linkedList;
		}
	}
}

using System;
using System.Collections.Generic;

namespace RemoveDupesFromLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

		public LinkedList<int> RemoveDuplicatesFromLinkedList(LinkedList<int> linkedList)
		{
			// Write your code here.

			// set up runner to list.Head
			// set up current to list.Head
			LinkedListNode<int> runner = linkedList.First;
			LinkedListNode<int> current = linkedList.First;

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
				// -  if current.value == runner.value => 
				//    move runner to runner.Next and delete runner.
				if (current.Value == runner.Value)
				{
					LinkedListNode<int> temp = runner;
					runner = runner.Next;
                    //current.Next = runner;
				}

				current = current.Next;

			}

			return linkedList;
		}
	}
}

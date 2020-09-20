using LinkedListLibrary;
using static LinkedListTests.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using LinkedListTests;

namespace LLPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is This LinkedList A Palindrome?");

			LinkedList list = new LinkedList();
			list.Append(1);
			list.Append(2);
			list.Append(3);
			list.Append(2);
			list.Append(1);

			if (IsAPalindrome(list))
            {
                Console.WriteLine("True! It is!");
            } 
			else
            {
				Console.WriteLine("False! It is not!");
			}

		}

		public static bool IsAPalindrome(LinkedList list)
		{
			Stack stack = new Stack();
			Node current = list.Head;
			int counter = 0;

			while (current != null)
			{
				counter++;
				current = current.Next;
			}

			decimal mid = Math.Ceiling((decimal)counter / 2);
			current = list.Head;

			if (counter % 2 != 0)
			{
		while (current != null)
				{
					if (counter < mid)
					{
						stack.Push(current.Value);
					}

					if (counter > mid)
					{
						if (current != stack.Pop())
						{
							return false;
						}
					}
					current = current.Next;
				}
			}

			if (counter % 2 == 0)
			{
				while (current != null)
				{
					if (counter <= mid)
					{
						stack.Push(current.Value);
					}

					if (counter > mid)
					{
						if (current != stack.Pop())
						{
							return false;
						}
					}
					current = current.Next;
				}
			}
			return true;
		}
	}
}

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

		//public static bool IsAPalindrome(LinkedList list)
		//{
  //          Stack stack = new Stack();
  //          Node current = list.Head;

		//	while (current != null)
		//	{
		//		stack.Push(current.Value);
		//		current = current.Next;
		//	}

		//	current = list.Head;

		//	while (current != null)
  //          {
		//		//TODO: match data types for stack (obj) and list (int)
		//		if (current.Value != stack.Pop())
		//		{
		//			return false;
		//		}
		//		stack.Pop();
		//		current = current.Next;
		//	}

		//	return true;
		//}
	}
}

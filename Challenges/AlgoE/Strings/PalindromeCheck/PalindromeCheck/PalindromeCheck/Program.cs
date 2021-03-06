﻿using System;
using System.Text;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Check: 3 Solutions");

            Console.WriteLine("1) StringBuilder / Iterative / Space = O(N) / Time = O(N)");

			Console.WriteLine("IsPalindrome1: " + IsPalindrome1("abb"));

			Console.WriteLine("2) Recursive / Space = O(N) / Time = O(N)");

			Console.WriteLine("IsPalindrome2: " + IsPalindrome2("abcdcba"));

			Console.WriteLine("3) Pointers / Iterative / Space = O(1) / Time = O(N)");

            Console.WriteLine("IsPalindrome3: " + IsPalindrome3("abb"));
        }

		public static bool IsPalindrome1(string str)
		{
			StringBuilder SB = new StringBuilder();

            for (int i = str.Length -1; i >= 0; i--)
            {
				SB.Append(str[i]);
            }

			string reversedStr = SB.ToString();

			bool result = reversedStr == str;

			return result;
		}

		public static bool IsPalindrome2(string str, int i = 0)
        {
			int j = str.Length - 1 - i;

			// Base case:
			if (i > j)
			{
				return true;
			}
			// Recursive case:
			else
			{
				return str[i] == str[j] && IsPalindrome2(str, i + 1);
			}
        }

		public static bool IsPalindrome3(string str)
		{
			int leftIdx = 0;
			int rightIdx = str.Length - 1;

			while (leftIdx < rightIdx)
			{
				if (str[leftIdx] != str[rightIdx])
				{
					return false;
				}
				leftIdx++;
				rightIdx--;
			}

			return true;
		}
	}
}

using System;
using System.Collections.Generic;

namespace NthFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NthFibonacci - 3 Solutions");

			// The nth Fibonacci number is: 
			// fib(n) = fib(n-1) + fib(n-2)  for n > 2
		}

		// Simple Recursive Solution - worst time
		// O(2^n) time | O(n) space
		public static int GetNthFib1(int n)
		{
			// base case:
			if (n == 2)
			{
				return 1;
			}

			if (n == 1)
			{
				return 0;
			}

			// recursive case: 			
			return GetNthFib1(n - 1) + GetNthFib1(n - 2);
		}


		// Recursive solution with a Dictionary - better time
		// O(n) time | O(n) space

		public static int GetNthFib2(int n)
		{
			Dictionary<int, int> table = new Dictionary<int, int>();
			table.Add(1, 0);
			table.Add(2, 1);
			return GetNthFib2(n, table);
		}

		private static int GetNthFib2(int n, Dictionary<int, int> table)
		{
			// base case:
			if (table.ContainsKey(n))
			{
				return table[n];
			}
			// recursive case:
			else
			{
				table.Add(n, GetNthFib2(n - 1, table) + GetNthFib2(n - 2, table));
				return table[n];
			}

		}

		// Iterative solution - best space
		// O(n) time | O(1) space
		public static int GetNthFib3(int n)
		{

			int[] lastTwo = { 0, 1 };
			int counter = 3;

			while (counter <= n)
			{
				int nextFib = lastTwo[0] + lastTwo[1];
				lastTwo[0] = lastTwo[1];
				lastTwo[1] = nextFib;
				counter++;
			}

			if (n > 1)
			{
				return lastTwo[1];
			}
			else
			{
				return lastTwo[0];
			}
		}
	}
}

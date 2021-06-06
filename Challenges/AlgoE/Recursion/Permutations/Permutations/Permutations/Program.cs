using System;
using System.Collections.Generic;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Permutations");

			List<int> test1 = new List<int>{ 1, 2, 3 };
			PrintListOfLists(GetPermutations(test1));
		}

		public static List<List<int>> GetPermutations(List<int> array)
		{
			List<List<int>> permutations = new List<List<int>>();
			PermutationsHelper(0, array, permutations);
			return permutations;
		}

		private static void PermutationsHelper(int i, List<int> array, List<List<int>> permutations)
		{
			// base case: i is the last element in the array
			if (i == array.Count - 1)
			{
				permutations.Add(new List<int>(array));
			}
			else
			{
				for (int j = i; j < array.Count; j++)
				{
					Swap(array, i, j);
					PermutationsHelper(i + 1, array, permutations);
					Swap(array, i, j);
				}
			}
		}

		private static void Swap(List<int> array, int i, int j)
		{
			int temp = array[i];
			array[i] = array[j];
			array[j] = temp;
		}

		private static void PrintListOfLists(List<List<int>> listOfLists)
        {
			foreach (List<int> subList in listOfLists)
			{
				foreach(int item in subList)
				{
					Console.Write(item);
				}
                Console.WriteLine();
			}
		}
	}
}

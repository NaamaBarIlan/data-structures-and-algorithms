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

			string test2 = "cow";
			PrintListOfCharLists(StringPermutations(test2));
		}

		public static List<List<char>> StringPermutations(string str)
        {
			List<char> inputString = StringToCharList(str);
			List<List<char>> permutations = new List<List<char>>();
			StringPermutationsHelper(0, inputString, permutations);
			return permutations;
        }

		private static void StringPermutationsHelper(int i, List<char> str, List<List<char>> permutations)
        {
			// base case: if i is the last char in the string,
			// then all of the chars have been visited, 
			// add str to the permutations list
			if(i == str.Count - 1)
            {
				permutations.Add(new List<char>(str));
            }
            else
            {
				for(int j = i; j < str.Count; j++)
                {
					CharSwap(str, i, j);
					StringPermutationsHelper(i + 1, str, permutations);
					CharSwap(str, i, j);
				}
            }
		}

		private static List<char> StringToCharList(string str)
		{
			List<char> list = new List<char>();
			foreach (char character in str)
			{
				list.Add(character);
			}
			return list;
		}

		private static void CharSwap(List<char> str, int i, int j)
		{
			char temp = str[i];
			str[i] = str[j];
			str[j] = temp;
		}

		private static void PrintListOfCharLists(List<List<char>> listOfLists)
		{
			foreach (List<char> subList in listOfLists)
			{
				foreach (char item in subList)
				{
					Console.Write(item);
				}
				Console.WriteLine();
			}
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

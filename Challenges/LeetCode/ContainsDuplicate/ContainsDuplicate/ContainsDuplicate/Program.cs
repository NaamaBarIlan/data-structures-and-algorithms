using System;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] example1 = { 1, 2, 3, 1 };
			int[] example2 = { 1, 2, 3, 4 };
			int[] example3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
			
			Console.WriteLine($"Example 1: {ContainsDuplicates(example1)}");
			Console.WriteLine($"Example 2: {ContainsDuplicates(example2)}");
			Console.WriteLine($"Example 3: {ContainsDuplicates(example3)}");
		}

		/// <summary>
		/// Finds if a given array of integers contains any duplicates. 
		/// </summary>
		/// <param name="intArr">The array of integers that is checked for duplicates</param>
		/// <returns>True if any value appears at least twice in the array, or false if every element is distinct</returns>
		public static bool ContainsDuplicates(int[] intArr)
		{
			bool hasDuplicates = false;

			for (int i = 0; i < intArr.Length; i++)
			{
				for (int j = i+1; j < intArr.Length; j++)
				{
					if (intArr[j] == intArr[i])
					{
						hasDuplicates = true;
						return hasDuplicates;
					}
				}
			}

			return hasDuplicates;
		}
	}
}

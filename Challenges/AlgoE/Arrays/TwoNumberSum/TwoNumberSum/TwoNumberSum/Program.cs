using System;
using System.Collections.Generic;

namespace TwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two Number Sum");

			int[] exampleArr = { 3, 5, -4, 8, 11, 1, -1, 6 };

            //Console.WriteLine("[{0}]", string.Join(", ", TwoNumberSum1(exampleArr, 10)));

			Console.WriteLine("[{0}]", string.Join(", ", TwoNumberSum2(exampleArr, 10)));

		}

		// simple solution - nested for loops
		// Time O(n^2) | Space O(1)
		public static int[] TwoNumberSum1(int[] array, int targetSum)
		{
			int[] output = new int[2];

			for (int i = 0; i < array.Length; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[i] + array[j] == targetSum)
					{
						output[0] = array[i];
						output[1] = array[j];
						return output;
					}
				}
			}
			return new int[0];
		}

		public static int[] TwoNumberSum2(int[] array, int targetSum)
		{
			HashSet<int> allNums = new HashSet<int>();
			int[] output = new int[2];

			foreach (int num in array)
            {
				allNums.Add(num);
            }

			for(int i = 0; i < array.Length; i++)
            {
				int makesTarget = targetSum - array[i];

                if (allNums.Contains(makesTarget))
                {
					output[0] = array[i];
					output[1] = makesTarget;
					return output;
                }
            }

			return new int[0];
		}
	}
}

using System;

namespace ThreeWaySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ThreeWaySort");
			int[] testArray1 = {1, 0, 0, -1, -1, 0, 1, 1};
			int[] testorder1 = {0, 1, -1};

			Console.WriteLine("Iterative, two iterations: ");

			PrintArray(ThreeNumberSort(testArray1, testorder1));
		}

		/// <summary>
		/// Given an array of integers and another array of three distinct integers
		/// Sorts in place the first array accourding to the desired order
		/// int the sercond array.
		/// </summary>
		/// <param name="array">The integer array to be sorted, 
		/// contains 3 distinct integers at most</param>
		/// <param name="order">The integer array representing the desired order
		/// for the integers in the first array</param>
		/// <returns>The input integer array, sorted by the input order array</returns>
		public static int[] ThreeNumberSort(int[] array, int[] order)
		{
			// set a firstIdx and a lastIdx
			int firstIdx = 0;
			int lastIdx = array.Length - 1;

			// first iteration over the aray
			// compare each element to the first element in order
			// if equal, swap with the element at firstIdx
			// increment firstIdx
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == order[0])
				{
					int temp = array[i];
					array[i] = array[firstIdx];
					array[firstIdx] = temp;
					firstIdx++;
				}
			}
			// second iteration over the aray, going from end to start
			// compare each element to the last element in order
			// if equal, swap with the element at lastIdx
			// decrement lastIdx
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if (array[i] == order[2])
				{
					int tempTwo = array[i];
					array[i] = array[lastIdx];
					array[lastIdx] = tempTwo;
					lastIdx--;
				}
			}
			return array;
		}


		public static void PrintArray(int[] array)
        {
			Console.WriteLine("[{0}]", string.Join(", ", array));
		}
	}
}

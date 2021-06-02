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

			//Console.WriteLine("Iterative, traversing the input array twice: ");
			//PrintArray(ThreeWaySort(testArray1, testorder1));

			Console.WriteLine("Recursive, devide and conquer: ");
			PrintArray(ThreeWaySort2(testArray1));
		}


		public static int[] ThreeWaySort2(int[] array)
		{
			ThreeWaySort2(array, 0, array.Length - 1);
			return array;
		}

		private static void ThreeWaySort2(int[] array, int startIdx, int endIdx)
        {
			// base case: an array of 0 or 1 elements
			if(startIdx >= endIdx)
            {
				return;
            }

			// edge case: if there are only 2 elements in the array
			if (endIdx - startIdx == 1)
            {
				if(array[startIdx] > array[endIdx])
                {
					SwapElements(startIdx, endIdx, array);
				}
				return;
            }

			// partition the array around the new pivot
			// and arrange the elements compared to the pivot
			(int, int) partitionIdx = partition(array, startIdx, endIdx);

			// recur on the sub-array of elements smaller than the pivot
			ThreeWaySort2(array, startIdx, partitionIdx.Item1);

			// recur on the sub-array of elements greater than the pivot
			ThreeWaySort2(array, partitionIdx.Item2, endIdx);
		}

		/// <summary>
		/// Partitions an array using the Dutch national flag algorithm
		/// </summary>
		/// <param name="array"></param>
		/// <param name="startIdx"></param>
		/// <param name="endIdx"></param>
		/// <returns></returns>
		private static (int startIdx, int endIdx) partition(int[] array, int startIdx, int endIdx)
        {
			int midIdx = startIdx;
			int pivot = array[endIdx];

			while(midIdx <= endIdx)
            {
                if(array[midIdx] < pivot)
                {
					SwapElements(startIdx, midIdx, array);
					startIdx++;
					midIdx++;
                }
				else if(array[midIdx] > pivot)
                {
					SwapElements(midIdx, endIdx, array);
					endIdx--;
                }
                else
                {
					midIdx++;
                }
            }

			return (startIdx -1, endIdx);
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
		public static int[] ThreeWaySort(int[] array, int[] order)
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


		private static void SwapElements(int i, int j, int[] array)
        {
			int temp = array[i];
			array[i] = array[j];
			array[j] = temp;
        }

		public static void PrintArray(int[] array)
        {
			Console.WriteLine("[{0}]", string.Join(", ", array));
		}
	}
}

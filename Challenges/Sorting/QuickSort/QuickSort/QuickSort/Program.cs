using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QuickSort");

			int[] testArr1 = { 8, 5, 2, 9, 5, 6, 3 };

			//Console.WriteLine("The pivot is the first element in the array:");
			//PrintArray(QuickSort(testArr1));

			Console.WriteLine("The pivot is the last element in the array:");
			PrintArray(QuickSort2(testArr1));
		}

		/// <summary>
		/// QuickSort using the first array element as the pivot
		/// </summary>
		/// <param name="array"></param>
		/// <returns></returns>
		public static int[] QuickSort(int[] array)
		{
			QuickSortHelper(array, 0, array.Length - 1);
			return array;
		}

		public static void QuickSortHelper(int[] array, int startIdx, int endIdx)
		{
			// base case: if array.Length == 1, no need to sort, return array;
			if (startIdx >= endIdx)
			{
				return;
			}
			// set a pivot - the first element in the array
			int pivotIdx = startIdx;
			// set left pointer, element next to pivot
			int leftIdx = startIdx + 1;
			// set right pointer, last element in the array
			int rightIdx = endIdx;
			// while left is smaller/equal to right, check:
			while (leftIdx <= rightIdx)
			{
				// if left is bigger than pivot and right is smaller than pivot, swap them (temp)
				if (array[leftIdx] > array[pivotIdx] && array[rightIdx] < array[pivotIdx])
				{
					SwapElements(leftIdx, rightIdx, array);
				}
				// if left is smaller than pivot, increment leff = move to the right
				if (array[leftIdx] <= array[pivotIdx])
				{
					leftIdx++;
				}
				// if right is bigger than pivot, decrement right = move to the left
				if (array[rightIdx] >= array[pivotIdx])
				{
					rightIdx--;
				}
			}
			// swap the pivot and right element
			SwapElements(pivotIdx, rightIdx, array);

			// recurse sub-arrays:
			QuickSortHelper(array, startIdx, rightIdx - 1);
			QuickSortHelper(array, rightIdx + 1, endIdx);
		}

		public static int[] QuickSort2(int[] array)
        {
			QuickSort2(array, 0, array.Length - 1);
			return array;
        }

		private static void QuickSort2(int[] array, int start, int end)
        {
			// base case:
			if(start >= end)
            {
				return;
            }

			// partition the array
			// and arrange the array elements around the pivot
			int pivot = Partition(array, start, end);

			// recur on the subarray of elements smaller than the pivot
			QuickSort2(array, start, pivot - 1);

			// recur on the subarray of elements greater than the pivot
			QuickSort2(array, pivot + 1, end);
        }

		/// <summary>
		/// Patitioning an array around a pivot element,
		/// the pivot is the last element of the array
		/// </summary>
		/// <param name="array"></param>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <returns></returns>
		private static int Partition(int[] array, int start, int end)
        {
			// Set the pivot of the array to the last(rightmost) element
			int pivot = array[end];

			// elements smaller than the pivot will be moved to the left of partitionIdx
			// elements greater than the pivot will be moved to the right of partitionIdx
			// elements equal to partitionIdx can go either way
			int partitionIdx = start;

			// Iterate over the array
			// Every time an element is smaller or equal to the pivot, 
			// 1. That element is placed before the pivot
			// 2. partitionIdx is incremented
			for (int i = start; i < end; i++)
            {
				if(array[i] <= pivot)
                {
					SwapElements(i, partitionIdx, array);
					partitionIdx++;
                }
            }

			//swapping partitionIdx with pivot 
			SwapElements(partitionIdx, end, array);

			// returning the index of the new pivot element
			return partitionIdx;
        }

		private static void SwapElements(int i, int j, int[] array)
		{
			int temp = array[j];
			array[j] = array[i];
			array[i] = temp;
		}

		public static void PrintArray(int[] array)
		{
			Console.WriteLine("[{0}]", string.Join(", ", array));
		}


	}
}

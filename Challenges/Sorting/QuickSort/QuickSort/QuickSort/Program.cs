using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QuickSort");
        }

		public static int[] QuickSort(int[] array)
		{
			QuickSortHelper(array, 0, array.Length - 1);
			return array;
		}

		public static void SwapElements(int i, int j, int[] array)
		{
			int temp = array[j];
			array[j] = array[i];
			array[i] = temp;
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
			int pivot = array[pivotIdx];
			// sort array in comparison to the pivot:
			// set left pointer, element next to pivot
			int leftIdx = startIdx + 1;
			int left = array[leftIdx];
			// set right pointer, last element in the array
			int rightIdx = endIdx;
			int right = array[rightIdx];
			// while left is smaller/equal to right, check:
			while (leftIdx <= rightIdx)
			{
				// if left is bigger than pivot and right is smaller than pivot, swap them (temp)
				if (left > pivot && right < pivot)
				{
					SwapElements(left, pivot, array);
				}
				// if left is smaller than pivot, increment leff = move to the right
				if (left <= pivot)
				{
					leftIdx++;
				}
				// if right is bigger than pivot, decrement right = move to the left
				if (right >= pivot)
				{
					rightIdx--;
				}
			}
			// swap the pivot and right element
			SwapElements(right, pivot, array);
			// check which sub array is smaller
			bool isLeftSubarrSmaller = rightIdx - 1 - startIdx < endIdx - (rightIdx + 1);
			// recurse sub-arrays:
			if (isLeftSubarrSmaller)
			{
				QuickSortHelper(array, startIdx, rightIdx - 1);
				QuickSortHelper(array, rightIdx + 1, endIdx);
			}
			else
			{
				QuickSortHelper(array, rightIdx + 1, endIdx);
				QuickSortHelper(array, startIdx, rightIdx - 1);
			}
		}
	}
}

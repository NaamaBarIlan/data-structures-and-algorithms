using System;

namespace BinarySearch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search");

			int[] arr1 = { 4, 8, 15, 16, 23, 42 };
			int key1 = 15;

			Console.WriteLine($"Example input 1:  {BinarySearch(arr1, key1)}");
        }

		public static int BinarySearch(int[] arr, int key)
		{
			int low = arr[0];
			int mid = arr[Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(arr.Length) / 2))];
			int high = arr[arr.Length - 1];

			if (mid == key)
			{
				return mid;
			}

			while (mid != high || mid != low)
{
				if (mid == key)
				{
					return mid;
				}

				if (mid > key)
				{
					high = mid;
					mid = arr[Convert.ToInt32(Math.Ceiling((Convert.ToDecimal(mid) / 2)))];
				}
				else
				{
					low = mid;
					mid = arr[Convert.ToInt32(Math.Ceiling((Convert.ToDecimal(mid + mid)) / 2))];
				}
			}

			return -1;
		}

	}
}

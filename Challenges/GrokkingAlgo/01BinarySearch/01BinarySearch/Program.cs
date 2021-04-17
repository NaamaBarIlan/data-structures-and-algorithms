using System;

namespace _01BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01 Binary Search");

            int[] myList = { 1, 3, 5, 7, 9 };

            Console.WriteLine(BinarySearch(myList, 3));

            Console.WriteLine(BinarySearch(myList, 4));
        }

        public static int? BinarySearch(int[] arr, int item)
        {
            int low = 0;
            int high = arr.Length - 1;

            while(low <= high)
            {
                int mid = (low + high) / 2;
                int guess = arr[mid];

                if(guess == item)
                {
                    return mid;

                } else if (guess > item)
                {
                    high = mid - 1;

                } else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}

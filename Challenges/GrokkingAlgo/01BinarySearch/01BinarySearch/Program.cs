using System;

namespace _01BinarySearch
{
    class Program
    {
        /// <summary>
        /// This excercise from Grokking Algorithms was converted to C# from Python
        /// Reference: https://www.manning.com/books/grokking-algorithms
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("01 Binary Search");

            int[] myList = { 1, 3, 5, 7, 9 };

            Console.WriteLine(BinarySearch(myList, 3));

            Console.WriteLine(BinarySearch(myList, 4));
        }

        public static int BinarySearch(int[] arr, int item)
        {
            //Set Low and high to keep track of which part of the list we'll search in.
            int low = 0;
            int high = arr.Length - 1;

            //While we haven't narrowed it down to one element....
            while (low <= high)
            {
                //... check the middle element
                int mid = (low + high) / 2;
                int guess = arr[mid];

                // If the item is found:
                if (guess == item)
                {
                    return mid;

                    
                } // If the guess was too high:
                else if (guess > item)
                {
                    high = mid - 1;

                } // If the guess was too low:
                else
                {
                    low = mid + 1;
                }
            }

            // If the item doesn't exist
            return -1;
        }
    }
}

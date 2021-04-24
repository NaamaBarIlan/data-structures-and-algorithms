using System;

namespace _02SelectionSort
{
    class Program
    {
        /// <summary>
        /// This is an excercise from Grokking Algorithms, for reference:
        /// https://www.manning.com/books/grokking-algorithms
        /// The solution is based on this Exception Not Found article:
        /// https://exceptionnotfound.net/selection-sort-csharp-the-sorting-algorithm-family-reunion/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] exampleArray = { 5, 3, 6, 2, 10 };
            int[] exampleArray2 = { 62, -31, 7, 14};
            Console.WriteLine("[{0}]", string.Join(", ", SelectionSort(exampleArray)));
            Console.WriteLine("[{0}]", string.Join(", ", SelectionSort(exampleArray2)));
        }

        /// <summary>
        /// Sorts an integer array from smallest to largest value.
        /// </summary>
        /// <param name="arr">The input integer array</param>
        /// <returns>A new integer array with 
        /// all elements sorted from smallest to largest value</returns>
        public static int[] SelectionSort(int[] arr)
        {            
            for (int i = 0; i < arr.Length; i++)
            {
                int smallestValue = arr[i];
                int smallestIndex = i;
                int temp;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < smallestValue)
                    {
                        smallestValue = arr[j];
                        smallestIndex = j;
                    }
                }

                temp = smallestValue;
                arr[smallestIndex] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }
}

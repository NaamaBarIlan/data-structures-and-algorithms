using System;

namespace _02SelectionSort
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
            int[] exampleArray = { 5, 3, 6, 2, 10 };
            Console.WriteLine(FindSmallest(exampleArray));
            //Array.ForEach(SelectionSort(exampleArray), Console.Write);
        }

        /// <summary>
        /// Sorts an integer array from smallest to largest value.
        /// </summary>
        /// <param name="arr">The input integer array</param>
        /// <returns>A new integer array with 
        /// all elements sorted from smallest to largest value</returns>
        //public static int[] SelectionSort(int[] arr)
        //{
        //    int[] newArr = new int[arr.Length];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        int smallest = FindSmallest(arr);
        //        newArr[i] = arr[smallest];
        //    }

        //    return newArr;
        //}

        /// <summary>
        /// Finds the smallest value in an array
        /// </summary>
        /// <param name="arr">The input integer array</param>
        /// <returns>The index of the smallest integer
        /// in the input array</returns>
        public static int FindSmallest(int[] arr)
        {
            //Stores the smallest value
            int smallestValue = arr[0];
            //Stores the index of the smallest value
            int smallestIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallestValue)
                {
                    smallestValue = arr[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }


    }
}

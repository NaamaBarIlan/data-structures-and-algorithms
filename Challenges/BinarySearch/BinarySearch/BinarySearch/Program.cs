using System;

namespace BinarySearch
{
    class Program
    {
        /// <summary>
        /// Runs the BinarySearch method with different sample inputs. 
        /// </summary>
        /// <param name="args">Default Main parameter</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search!");

            int[] sampleArr1 = new int[] { 4, 8, 15, 16, 23, 42 };
            int key1 = 15;

            Console.WriteLine("Sample #1: " + BinarySearch(sampleArr1, key1));

            int[] sampleArr2 = new int[] { 11, 22, 33, 44, 55, 66, 77 };
            int key2 = 90;

            Console.WriteLine("Sample #2: " + BinarySearch(sampleArr2, key2));

            int[] sampleArr3 = new int[] { 4, 8, 15, 16, 23, 42};
            int key3 = 23;

            Console.WriteLine("Sample #3: " + BinarySearch(sampleArr3, key3));
        }

        /// <summary>
        /// Takes in 2 parameters: a sorted array and the search key. 
        /// Return the index of the array’s element that is equal to the search key, 
        /// or -1 if the element does not exist
        /// </summary>
        /// <param name="array">The sorted int array to be searched</param>
        /// <param name="key">The int element that will be searched in the array</param>
        /// <returns>The index of the key element in the array, or -1 if cannot be found</returns>
        public static int BinarySearch(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + ((right - left) / 2);

                if (array[mid] == key)
                {
                    return mid;
                }
                else if (key < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}

using System;
using System.Collections.Generic;

namespace _04QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divide & Conquer - Quick Sort");

            int[] example = { 2, 4, 6 };
            Console.WriteLine(SumArray(example));

            List<int> example2 = new List<int> { 2, 4, 6 };
            Console.WriteLine(CountListItems(example2));
        }


        public static int SumArray(int[] array)
        {
            int idx = array.Length - 1;
            return SumArrayHelper(array, idx);
        }

        private static int SumArrayHelper(int[] arr, int idx)
        {
            if (idx == 0)
            {
                return arr[idx];
            }

            return arr[idx] + SumArrayHelper(arr, idx - 1);

        }

        public static int CountListItems(List<int> list)
        {
            int idx = list.Count - 1;
            return CountListItemsHelper(list, idx);
        }

        public static int CountListItemsHelper(List<int> list, int idx)
        {
            if(idx == 0)
            {
                return 1;
            }

            return 1 + CountListItemsHelper(list, idx - 1);
        }
    }
}

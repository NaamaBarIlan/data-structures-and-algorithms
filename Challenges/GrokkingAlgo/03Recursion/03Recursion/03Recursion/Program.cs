using System;
using System.Collections.Generic;

namespace _03Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion!");

            Console.WriteLine("1. Countdown:");
            Countdown(5);

            // ======================================

            Console.WriteLine("2. Sum array: ");

            int[] exArr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(SumArray(exArr, exArr.Length - 1));
        }

        public static int CountListItems(LinkedList<int> list)
        {
            return 0;
        }

        public static int SumArray(int[] arr, int n)
        {
            if(n == 0)
            {
                return arr[n];
            }

            return arr[n] + SumArray(arr, n - 1);

        }

        public static void Countdown(int i)
        {
            Console.WriteLine(i);

            if (i > 0)
            {
                Countdown(i - 1);
            }
        }

        
    }
}

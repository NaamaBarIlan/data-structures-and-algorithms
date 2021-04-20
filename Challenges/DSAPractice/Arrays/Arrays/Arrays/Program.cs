using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {

        // Problem:
        // Given an array and a number, 
        // Are there 2 numbers in the arr that would add up to the number?
        // Ex 1 input:  [1, 3, 5, 7, 9], 8 => return true
        // Ex 2 input: [1, 3, 5, 7, 9], 15 => return false

        static void Main(string[] args)
        {
            int[] exampleArr = { 1, 3, 5, 7, 9 };

            Console.WriteLine("Example 1 is: " + SumOfTwoNumbers(exampleArr, 8));
            Console.WriteLine("Example 2 is: " + SumOfTwoNumbers(exampleArr, 15));
        } 

        public static bool SumOfTwoNumbers(int[] arr, int target)
        {
            HashSet<int> inputNumbers = new HashSet<int>();

            for(int i = 0; i < arr.Length; i++)
            {
                inputNumbers.Add(arr[i]);
            }

            foreach(int num in arr)
            {
                int lookupNum = target - num;

                if(inputNumbers.Contains(lookupNum))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

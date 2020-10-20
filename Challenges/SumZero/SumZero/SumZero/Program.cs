using System;

namespace SumZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Zero:");

            int[] input1 = { -4, -3, -2, -1, 0, 1, 2, 3, 10 };
            int[] result1 = SumZero(input1);
            Console.WriteLine(string.Join(" ", result1));

            int[] input2 = { -4, -3, -2, -1, 0, 5, 10 };
            int[] result2 = SumZero(input2);
            Console.WriteLine(string.Join(" ", result2));
        }

        public static int[] SumZero(int[] arr)
        {
            int left = arr[0];
            int right = arr[arr.Length - 1];
            int[] result = new int[2];

            while (left < right)
            {
                int sum = left + right;
                
                if (sum == 0)
                {
                    result[0] = left;
                    result[1] = right;
                    return result;
                } 
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return result;
        }
    }
}

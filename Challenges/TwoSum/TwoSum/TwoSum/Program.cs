using System;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two Sum");

            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] output = TwoSum(nums, target);

            Console.WriteLine("[{0}]", string.Join(", ", output));
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int first;
            int second;
            int[] output = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                first = nums[i];

                for (int j = i + 1; j < nums.Length; j++)
                {
                    second = nums[j];

                    if (first + second == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        return output;
                    }
                }
            }
            return null;
        }
    }
}

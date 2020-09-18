using System;
using System.Collections.Generic;

namespace CountTriplets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Count All Triplets!");

            int[] sampleInput1 = new int[] { 1, 5, 3, 2 };

            int[] sampleInput2 = new int[] { 1, 5, 3, 2, 6, 10, 4, 8, 9, 7 };

            var result = FindAllTriplets(sampleInput2);

            foreach (var item in result)
            {
                Console.WriteLine("[{0}]", string.Join(", ", item)); ;
            }           

        }

        public static List<int[]> FindAllTriplets(int[] inputArr)
        {
            List<int[]> allArrays = new List<int[]>();

            for (int i = 0; i < inputArr.Length; i++)
            {
                int slowWalker = inputArr[i];

                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    int walker = inputArr[j];

                    for (int k = j + 1; k < inputArr.Length; k++)
                    {
                        int runner = inputArr[k];
                        if (slowWalker + walker == runner || slowWalker + runner  == walker || walker + runner == slowWalker)
                        {
                            int[] array = new int[3] { slowWalker, walker, runner };
                            allArrays.Add(array);
                        }
                    }
                }
            }

            return allArrays;
        }
    }
}

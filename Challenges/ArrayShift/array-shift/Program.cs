using System;


namespace array_shift
{
    public class Program
    {
        /// <summary>
        /// This method calls the InsertShiftArray method with the input parameters. 
        /// </summary>
        /// <param name="args">Default method signature</param>
        static void Main(string[] args)
        {
            int[] inputArray = { 4, 8, 15, 23, 42 };
            int insertValue = 16;

            int[] outputArray = InsertShiftArray(inputArray, insertValue);
            Console.WriteLine("[{0}]", string.Join(", ", outputArray));
        }

        /// <summary>
        /// This method takes in an array and the value to be added 
        /// and returns an array with the new value added at the middle index.
        /// </summary>
        /// <param name="array">An int array</param>
        /// <param name="value">An int data type</param>
        /// <returns>A new integer array with the added integer in the middle index position</returns>
        public static int[] InsertShiftArray(int[] array, int value)
        {
            int[] outputArray = new int[array.Length + 1];

            decimal arrayMiddle = Math.Ceiling((decimal)(array.Length + 1) / 2);

            int counter = 0;

            for (int i = 0; i < outputArray.Length; i++)
            {
                if (i == arrayMiddle - 1)
                {
                    outputArray[i] = value;
                }
                else
                {
                    outputArray[i] = array[counter++];
                }
            }
            return outputArray;
        }
    }
}
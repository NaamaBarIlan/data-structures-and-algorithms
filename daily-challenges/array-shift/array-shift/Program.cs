using System;
namespace array_shift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray;
            int insertValue;
            insertShiftArray(inputArray, insertValue);
        }
        static int insertShiftArray(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            int newValuePlacement = (array.Length + 1) / 2;
            int indexPlace = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == newValuePlacement - 1)
                {
                    newArray[i] = value;
                }
                else if (i != newValuePlacement - 1)
                {
                    newArray[i] = array[indexPlace++];
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
            }
            return newArray;
        }
    }
}
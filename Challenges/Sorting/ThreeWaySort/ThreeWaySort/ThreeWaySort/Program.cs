using System;

namespace ThreeWaySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ThreeWaySort");
			int[] testArray1 = {1, 0, 0, -1, -1, 0, 1, 1};
			int[] testorder1 = {0, 1, -1};

			Console.WriteLine("Iterative, two iterations: ");
			Console.WriteLine("[{0}]", string.Join(", ", ThreeNumberSort(testArray1, testorder1)));
		}

		public static int[] ThreeNumberSort(int[] array, int[] order)
		{
			// set a firstIdx and a lastIdx
			int firstIdx = 0;
			int lastIdx = array.Length - 1;

			// first iteration over the aray
			// compare each element to the first element in order
			// if equal, swap with the element at firstIdx
			// increment firstIdx
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == order[0])
				{
					int temp = array[i];
					array[i] = array[firstIdx];
					array[firstIdx] = temp;
					firstIdx++;
				}
			}
			// second iteration over the aray, going from end to start
			// compare each element to the last element in order
			// if equal, swap with the element at lastIdx
			// decrement lastIdx
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if (array[i] == order[2])
				{
					int tempTwo = array[i];
					array[i] = array[lastIdx];
					array[lastIdx] = tempTwo;
					lastIdx--;
				}
			}
			return array;
		}
	}
}

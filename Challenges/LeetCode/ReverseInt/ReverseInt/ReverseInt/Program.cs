using System;

namespace ReverseInt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Integer!");

            Console.WriteLine(ReverseInteger(123));

            Console.WriteLine(ReverseInteger(-123));

            Console.WriteLine(ReverseInteger(120));
        }

        /// <summary>
        /// Reverses digits of an integer, given a 32-bit signed integer
        /// </summary>
        /// <param name="x">A 32-bit signed integer</param>
        /// <returns>The reversed integer</returns>
        public static int ReverseInteger(int x)
        {
            if (x > int.MaxValue)
            {
                return 0; 
            }

            bool negative = false;

            if (x < 0)
            {
                negative = true;
                x *= -1;
            }

            // convert int to string
            string inputString = x.ToString();

            char[] outputArray = new char[inputString.Length];

            // traverse the string and reverse it
            for (int i = 0, j = inputString.Length -1; i < inputString.Length; i++, j--)
            {
                outputArray[i] = inputString[j];
            }

            string resultString = new string(outputArray);

            // convert reverse string back to int

            int result = Int32.Parse(resultString);

            if (negative)
            {
                result *= -1;
            }

            return result;
        }
        
    }
}

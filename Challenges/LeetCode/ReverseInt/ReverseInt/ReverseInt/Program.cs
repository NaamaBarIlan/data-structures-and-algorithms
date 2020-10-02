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

        public static int ReverseInteger(int x)
        {
            if (x < 0)
            {
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

            if (x < 0)
            {
                result *= -1;
            }

            return result;
        }
        
    }
}

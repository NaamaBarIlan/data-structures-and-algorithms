using System;

namespace _03Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion!");

            Countdown(5);
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

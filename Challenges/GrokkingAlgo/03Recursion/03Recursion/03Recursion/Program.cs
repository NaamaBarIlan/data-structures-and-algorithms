using System;

namespace _03Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion!");

            Console.WriteLine("1. Countdown:");
            Countdown(5);


            Console.WriteLine("2. Greet:");
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

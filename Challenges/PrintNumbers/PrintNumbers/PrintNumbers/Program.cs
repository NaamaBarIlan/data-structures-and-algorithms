using System;

namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumber(115);
        }
        public static void PrintNumber(int value)
        {
            int[] digits = new int[3];
            int index = 2;
            while (index >= 0)
            {
                digits[index] = value % 10;
                value = value / 10;
                index--;
            }
            for (int i = 0; i < digits.Length; i++)
            {
                if (i == 0)
                {
                    OnesPlace(digits[i]);
                    Console.Write(" hundred ");
                }
                else if (i == 1)
                {
                    if (digits[i] == 1)
                    {
                        int teenValue = 10 + digits[i + 1];
                        Teens(teenValue);
                        break;
                    }
                    else
                    {
                        TensPlaceNotTeens(digits[i]);
                    }
                    Console.Write(" ");
                }
                else
                {
                    if (digits[i] > 0)
                    {
                        OnesPlace(digits[i]);
                    }
                }
            }
        }
        public static void OnesPlace(int value)
        {
            switch (value)
            {
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                case 4:
                    Console.Write("four");
                    break;
                case 5:
                    Console.Write("five");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("seven");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                case 9:
                    Console.Write("nine");
                    break;
                case 0:
                    Console.Write("zero");
                    break;
                default:
                    break;
            }
        }
        public static void TensPlaceNotTeens(int value)
        {
            switch (value)
            {
                case 2:
                    Console.Write("twenty");
                    break;
                default:
                    break;
            }
        }
        public static void Teens(int value)
        {
            switch (value)
            {
                case 10:
                    Console.Write("ten");
                    break;
                case 11:
                    Console.Write("eleven");
                    break;
                case 12:
                    Console.Write("twelve");
                    break;
                case 13:
                    Console.Write("thirteen");
                    break;
                case 14:
                    Console.Write("fourteen");
                    break;
                case 15:
                    Console.Write("fifteen");
                    break;
                case 16:
                    Console.Write("sixteen");
                    break;
                case 17:
                    Console.Write("seventeen");
                    break;
                case 18:
                    Console.Write("eighteen");
                    break;
                case 19:
                    Console.Write("nineteen");
                    break;
                default:
                    break;
            }
        }
    }
}
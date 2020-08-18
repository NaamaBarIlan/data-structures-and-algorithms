using System;
using System.Collections;

namespace RepeatedWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "Once upon a time, there was a brave princess who...";

            FindRepeatedWord(input);
        }

        public static string FindRepeatedWord(string input)
        {
            Hashtable Hashtbl = new Hashtable();

            string[] words = input.Split(' ', ',', '.', ':', '"');

            foreach (var item in words)
            {
                if(Hashtbl.Contains(item))
                {
                    Console.WriteLine($"{item}");
                    return item;
                }
                else
                {
                    Hashtbl.Add(item, 1);
                }
            }

            Console.WriteLine("There are no repeated words in this sentence.");
            return null;

        }

    }
}

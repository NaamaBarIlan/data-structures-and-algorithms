using System;
using System.Collections;
using System.Collections.Generic;

namespace RepeatedWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";

            FindRepeatedWord(input);
        }

        /// <summary>
        /// Takes a string input as parameter and returns the first word
        /// to occur more than once in that string
        /// </summary>
        /// <param name="input">The string that will be analyzed</param>
        /// <returns>The first repeated word in the string</returns>
        public static string FindRepeatedWord(string input)
        {
            Hashtable Hashtbl = new Hashtable();

            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            string[] words = input.ToLower().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

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

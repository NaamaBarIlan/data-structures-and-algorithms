using System;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valid Anagrams!");


        }

        /// <summary>
        /// Given two strings, determines if the second string is an 
        /// anagram of the first string. 
        /// </summary>
        /// <param name="str1">The first string that is being analyzed</param>
        /// <param name="str2">The second string that is being analyzed</param>
        /// <returns>A true if the second string is an anagram of the first, or false</returns>
        public static bool ValidAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            int counter1 = 0;
            int counter2 = 0;

            foreach (char item in str1)
            {
                 
            }
        }
    }
}

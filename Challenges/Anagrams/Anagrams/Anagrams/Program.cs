using System;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valid Anagrams!");

            // Expected Output: true

            string example1 = "anagram";
            string example1a = "nagaram";

            Console.WriteLine(ValidAnagram(example1, example1a));

            // Expected Output: false
            string example2 = "aaz";
            string example2a = "zza";

            Console.WriteLine(ValidAnagram(example2, example2a));

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

            int[] counter = new int[26];

            for (int i = 0; i < str1.Length; i++)
            {
                counter[str1[i] - 'a']++;
                counter[str2[i] - 'a']--;
            }

            foreach (var item in counter)
            {
                if(item != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using System;

namespace CrawlerLogFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crawler Log Folder:");

            string[] example1 = new string[5]{"d1/", "d2/", "../", "d21/", "./"};
            Console.WriteLine($"The minimum number of operations is {MinOperations(example1)}");

            string[] example2 = new string[6] {"d1/", "d2/", "./", "d3/", "../", "d31/"};
            Console.WriteLine($"The minimum number of operations is {MinOperations(example2)}");

            string[] example3 = new string[4] {"d1/", "../", "../", "../"};
            Console.WriteLine($"The minimum number of operations is {MinOperations(example3)}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public static int MinOperations(string[] logs)
        {
            int counter = 0;

            // iterate through the array
            for (int i = 0; i < logs.Length; i++)
            {
                // check each item and update the counter if needed
                if (logs[i] == "../" && counter != 0)
                {
                    counter--;
                }
                else if (logs[i] != "../" && logs[i] != "./")
                {
                    counter++;
                }

            }

            return counter;
        }
    }
}

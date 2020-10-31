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
        /// Takes a a list of strings logs, that represent a file system 
        /// which keeps a log each time a user performs a change folder operation.
        /// logs[i] is the operation performed by the user at the ith step.
        /// The file system starts in the main folder, then the operations in logs are performed.
        /// Calculates the minimum number of operations needed to go back to the main folder after the change folder operations.
        /// </summary>
        /// <param name="logs"></param>
        /// <returns>Minimum number of operations back to the main folder</returns>
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

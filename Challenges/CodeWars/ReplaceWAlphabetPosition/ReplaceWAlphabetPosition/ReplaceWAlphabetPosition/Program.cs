using System;
using System.Collections;
using System.Text;

namespace ReplaceWAlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

		public static string AlphabetPosition(string str)
		{
			Hashtable alphabetTable = new Hashtable();
			string alphabetString = "abcdefghijklmnopqrstuvwxyz";
			StringBuilder SB = new StringBuilder();
			string lowerCaseString = str.ToLower();

			for (int i = 1; i < alphabetString.Length + 1; i++)
			{
				alphabetTable.Add("alphabetString[i]", "i");
			}

			foreach (char item in lowerCaseString)
			{
				if (!char.IsLetter(item))
				{
					continue;
				}
				else
				{
					SB.Append(alphabetTable["item"]);
				}

			}

			return SB.ToString();
		}

	}
}

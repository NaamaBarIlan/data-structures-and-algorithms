using System;
using System.Collections;
using System.Text;

namespace ReplaceWAlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
			AlphabetPosition("The sunset sets at twelve o' clock.");
			AlphabetPosition("The narwhal bacons at midnight.");
		}

		public static string AlphabetPosition(string str)
		{
			Hashtable alphabetTable = new Hashtable();
			string alphabetString = "abcdefghijklmnopqrstuvwxyz";
			StringBuilder SB = new StringBuilder();
			string lowerCaseString = str.ToLower();

			for (int i = 0; i < alphabetString.Length; i++)
			{
				alphabetTable.Add(alphabetString[i], i+1);
			}

			foreach (char item in lowerCaseString)
			{
				if (!char.IsLetter(item))
				{
					continue;
				}
				else
				{
					SB.Append($"{alphabetTable[item]} ");
				}
			}

			Console.WriteLine($"{SB.ToString()}");
			return SB.ToString();
		}

	}
}

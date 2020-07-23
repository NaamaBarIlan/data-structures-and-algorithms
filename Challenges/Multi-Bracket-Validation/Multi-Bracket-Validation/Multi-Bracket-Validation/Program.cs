using System;
using System.Collections;



namespace Multi_Bracket_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool MultiBracketValidation(string str)
        {
            Stack stack = new Stack();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == "{" || str[i] == "(" || str[i] == "[")
                {
                    stack.Push(str[i]);
                }
                else if (str[i] == "}" || str[i] == ")" || str[i] == "]")
                {
                    if (str[i] == "}" && stack.Top == "{" || str[i] == ")" && stack.Top == "(" || str[i] == "]" && stack.Top == "[")
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }

            return stack.IsEmpty();
        }
    }
}

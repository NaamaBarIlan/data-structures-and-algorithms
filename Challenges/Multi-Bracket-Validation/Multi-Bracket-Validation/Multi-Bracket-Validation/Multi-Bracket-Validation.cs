using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Bracket_Validation
{
    public class MultiBracketValidation
    {
        public bool MBracketValidation(string str)
        {
            Stack stack = new Stack();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{' || str[i] == '(' || str[i] == '[')
                {
                    stack.Push(str[i]);
                }
                else if (str[i] == '}' || str[i] == ')' || str[i] == ']')
                {
                    if (str[i] == '}' && stack.Top.Value == '{' 
                        || str[i] == ')' && stack.Top.Value == '(' 
                        || str[i] == ']' && stack.Top.Value == '['
                        )
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

        public void testMethod()
        {
            Console.WriteLine("test");
        }

    }
}

using System;

namespace MultiBracketValidation
{
    public class Multi_Bracket_Validation
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

    }
}

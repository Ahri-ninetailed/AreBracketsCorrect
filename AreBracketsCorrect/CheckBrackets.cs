using System;
using System.Collections.Generic;
namespace AreBracketsCorrect
{
    class CheckBrackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreBracketsCorrect("([)]"));
        }
        static bool AreBracketsCorrect(string inputString)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '{' || inputString[i] == '(' || inputString[i] == '[')
                    stack.Push(inputString[i]);

                char tempsymb = stack.Peek();
                if ((inputString[i] == '}' && tempsymb == '{') || (inputString[i] == ')' && tempsymb == '(') || (inputString[i] == ']' && tempsymb == '['))
                    stack.Pop();
            }
            if (stack.Count == 0)
                return true;
            return false;
        }
    }
}

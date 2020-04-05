using System;
using System.Collections.Generic;

namespace LeetCode20
{
    class Program
    {
        static void Main(string[] args)
        {
            string given = "(]";
            Console.WriteLine(IsValid(given));
        }

        public static bool IsValid(string s)
        {
            Stack<char> symbol = new Stack<char>();

            foreach(var item in s)
            {
                if (item == '[' || item == '{' || item == '(')
                {
                    symbol.Push(item);
                }
                else if (symbol.Count != 0)
                {
                    if (item == ']' && symbol.Peek() == '[') symbol.Pop();
                    else if (item == '}' && symbol.Peek() == '{') symbol.Pop();
                    else if (item == ')' && symbol.Peek() == '(') symbol.Pop();
                    return false;
                }
                else return false;
            }
            return symbol.Count == 0;
        }
    }
}

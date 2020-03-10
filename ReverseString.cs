using System;

namespace LeetCode344
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] given = { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(given);
        }
        public static void ReverseString(char[] s)
        {
            // get the length of an array
            int n = s.Length - 1;

            for (int i = 0; i <= n; i++)
            {
                // store first letter in temp variable
                char temp = s[i];
                // replace first letter with last letter
                s[i] = s[n];
                // replace last letter with first letter from temp
                s[n] = temp;
                // reduce length
                n -= 1;
            }
            Console.WriteLine(s);
        }
    }
}

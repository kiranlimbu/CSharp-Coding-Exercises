using System;
using System.Collections.Generic;

namespace LeetCode412
{
    class Program
    {
        static void Main(string[] args)
        {
            int given = 15;
            Console.WriteLine(string.Join(",\n", FizzBuzz(given))); ;
        }
        public static IList<string> FizzBuzz(int n)
        {
            // initialize list<string>
            var zap = new List<String>();

            for (int i = 1; i <= n; i++)
            {
                // if multiple of 3 and 5, add 'FizzBuzz'
                if (i % 3 == 0 && i % 5 == 0)
                {
                    zap.Add("FizzBuzz");
                }
                // if multiple of only 3, add 'Fizz'
                else if (i % 3 == 0)
                {
                    zap.Add("Fizz");
                }
                // if multiple of only 5, add 'Buzz'
                else if (i % 5 == 0)
                {
                    zap.Add("Buzz");
                }
                // else add the number
                else
                {
                    zap.Add(i.ToString());
                }
            }
            return zap;
        }
    }
}

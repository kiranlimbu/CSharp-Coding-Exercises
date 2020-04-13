using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode5380
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "leetcode", "et", "code" };
            IList<string> hello = StringMatching(words);

            foreach (var item in hello)
            {
                Console.WriteLine(item);
            }

        }

        public static IList<string> StringMatching(string[] words)
        {
            List<string> match = new List<string>();
            words = words.OrderBy(x => x.Length).ToArray();

            int n = words.Length;

            for (int i=0; i<n; i++)
            {
                for (int j=i+1; j<n; j++)
                {
                    if (words[j].Contains(words[i]))
                    {
                        match.Add(words[i]);
                    }                  
                }
            }
            return match;
        }
    }
}

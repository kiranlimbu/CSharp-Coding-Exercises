using System;
using System.Collections.Generic;
using System.Threading;

namespace LeetCode202
{
    class Program
    {
        static void Main(string[] args)
        {
            int given = 19;
            Console.WriteLine(IsHappy(given));
        }

        public static bool IsHappy(int n)
        {
            int sqrSum = 0;
            HashSet<int> set = new HashSet<int>();

            while (n > 0)
            {
                sqrSum = (n % 10)*(n % 10) + sqrSum;
                n /= 10;

                // if integer is completely broken
                if (n == 0)
                {
                    // if the sum of sqr is 1 return true
                    if (sqrSum == 1) return true;
                    // replace n value with new sqr sum
                    n = sqrSum;
                    // helps break out of infinite loop
                    // check if HashSet contains sum
                    if (set.Contains(sqrSum)) break;
                    // add sum to HashSet
                    else
                    {
                        set.Add(sqrSum);
                        // reset the value of sqrSum
                        sqrSum = 0;
                    }
                }
            }
            return false;
        }
    }
}

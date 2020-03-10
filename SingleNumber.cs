using System;
using System.Collections.Generic;

namespace SingleInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] given = {1,2,2,3,4,3,4,5,5};
            int res = SingleNumber2(given);
            Console.WriteLine(res);
        }
        public static int SingleNumber1(int[] nums)
        {
            // sort the array
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                // check current value with next value
                if (nums[i] != nums[i + 1])
                {
                    // if not same, return the value
                    return nums[i];
                }
                // else move two step forward
                else
                {
                    i += 1;
                }
            }
            // return that last value
            return nums[^1];
        }

        // Better Version
        public static int SingleNumber2(int[] nums)
        {
            int result = 0;
            // iterate through each value in array
            foreach (int n in nums)
            {
                // using exclusive OR(^) operator store non dup value
                result ^= n;
            }
            return result;
        }
    }
}

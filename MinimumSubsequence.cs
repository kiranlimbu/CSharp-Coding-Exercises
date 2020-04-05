using System;
using System.Collections.Generic;
using System.Linq;

namespace _4April2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4,3,10,9,8 };
            var result = MinSubsequence(nums);
            Console.WriteLine(string.Join(" ", result));
        }

        public static IList<int> MinSubsequence(int[] nums)
        {
            List<int> minSub = new List<int>();

            if (nums.Max() > nums.Sum() || nums.Length == 1)
            {
                minSub.Add(nums.Max());
                return minSub;
            }

            int idx = 0;
            while (idx < nums.Length)
            {
                int bigNum = nums.Max();
                minSub.Add(bigNum);             

                // big number in the front
                nums[Array.IndexOf(nums, bigNum)] = 0;

                if (minSub.Sum() > nums.Sum()) return minSub;

                idx++;
            }

            return minSub;
        }
    }
}

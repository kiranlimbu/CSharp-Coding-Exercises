using System;
using System.Collections.Generic;

namespace LeetCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] given = { 2, 12, 11, 7 };
            Console.WriteLine(string.Join(" ", TwoSum1(given, 9)));
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] arr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int result = nums[i] + nums[j];

                    if (result == target)
                    {
                        arr[0] = i;
                        arr[1] = j;
                        return arr;
                    }
                }
            }
            return arr;
        }

        // faster version, using Dictionary
        public static int[] TwoSum1(int[] nums, int target)
        {
            int[] arr = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // check if dictionary contains other half
                if (dict.ContainsKey(target - nums[i]))
                {
                    // store index number
                    arr[1] = i;
                    arr[0] = dict[target - nums[i]];
                    break;
                }
                // add element of an num array as key and i as value
                else
                {
                    dict[nums[i]] = i;
                }
            }
            return arr;
        }
    }
}

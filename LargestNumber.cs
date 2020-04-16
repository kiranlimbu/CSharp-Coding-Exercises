using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5382
{
    class Program
    {
        // LeetCode Problem 179
        static void Main(string[] args)
        {
            int[] num = { 10, 2, 4, 567, 23, 20 }; // 10, 2, 4, 567, 23, 20
            Console.WriteLine(LargestNumber1(num));
        }

        // faster then 5%
        public static string LargestNumber(int[] nums)
        {
            if (nums.Length < 2 || nums.Max() == 0) return nums[0].ToString();

            string[] arr = nums.Select(x => x.ToString()).ToArray();

            for (int j=0; j<arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++) // 9, 5, 3, 30, 34
                {
                    string sumA = arr[i] + arr[i + 1];
                    string sumB = arr[i + 1] + arr[i];
                    int res = sumA.CompareTo(sumB);

                    if (res == -1)
                    {
                        string temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }

            var result = new StringBuilder();
            foreach (var item in arr)
            {
                result.Append(item);
            }

            return result.ToString();
        }

        // faster then 24%
        public static string LargestNumber1(int[] nums)
        {
            if (nums.Length < 2 || nums.Max() == 0) return nums[0].ToString();

            Array.Sort(nums, (x, y) =>
            {
                if (x == y) return 0;
                string X = x.ToString() + y.ToString();
                string Y = y.ToString() + x.ToString();
                return Y.CompareTo(X);              
            });

            var result = new StringBuilder();
            foreach (var item in nums)
            {
                result.Append(item.ToString());
            }

            return result.ToString();
        }
    }
}

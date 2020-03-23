using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode1389
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 2, 4, 3, 2 };
            int[] index = { 0, 0, 1, 3, 1 };

            Console.WriteLine(string.Join(" ", CreateTargetArray(nums, index)));
        }

        // for this problem this does not work
        // this only works when inbetween indexs are not missing
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] target = new int[index.Length];
            int[] valid = new int[index.Length];

            for (int i = 0; i < index.Length; i++)
            {
                // if the index number exist then do following
                if (Array.Exists(valid, x => x == index[i]) && i != 0)
                {
                    int count = index[i];
                    int current = target[count];
                    while (count < i)
                    {
                        int temp = target[count + 1];
                        target[count + 1] = current;
                        current = temp;
                        count++;
                    }
                }
                target[index[i]] = nums[i];
                valid[i] = index[i];
            }
            return target;
        }

        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> target = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                target.Insert(index[i], nums[i]);
            }
            
            return target.ToArray();
        }
    }
}

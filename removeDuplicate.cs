using System;
using System.Collections;

namespace removeDuplicate
{
    class RemoveDuplicate
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(arr));
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int n = nums.Length;
            int count = 1;
            int curr = 0;
            // if no element in the array, return 0
            if (n < 1) { return 0; }

            for (int i = 1; i < n; i++)
            {
                // if current is not equal to next
                if (nums[curr] != nums[i])
                {
                    // then add the non dup to the array
                    nums[count] = nums[i];
                    // move current position to next
                    curr = i;
                    // add count
                    count++;
                }
            }
            // return length of unique numbers array
            return count;
        }
    }
}

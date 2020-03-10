using System;

namespace LeetCode66
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] given = { 4, 3, 2, 1 };
            Console.WriteLine(string.Join(" ", PlusOne(given)));
        }
        public static int[] PlusOne(int[] digits)
        {
            // length of given array
            int n = digits.Length - 1;
            // store index of last int
            int last = n;

            for (int i = n; i >= 0; i--)
            {
                // check if last value is equal or greater then 9
                if (digits[last] >= 9)
                {
                    // replace last value with 0
                    digits[i] = 0;
                    // move to index infront
                    last = i - 1;
                    // check if the pointer is at first index
                    if (i == 0)
                    {
                        // initialize new arrary
                        int[] New_digits = new int[n + 2];
                        // assign 1 to first index
                        New_digits[0] = 1;
                        // copy the old array value to new array
                        for (int j = 0; j < n + 1; j++)
                        {
                            New_digits[j + 1] = digits[j];
                        }
                        return New_digits;
                    }
                }
                else
                {
                    // add 1 to current index
                    digits[i] += 1;
                    break;
                }
            }
            return digits;
        }
    }
}

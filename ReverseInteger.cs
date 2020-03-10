using System;
using System.Collections.Generic;

namespace LeetCode
{
    class ReverseInteger
    {
        static void Main(string[] args)
        {
            int x = -140;
            Console.WriteLine(reverse(x));

        }

        public static int reverse(int x)
        {
            int result = 0;
            // loop until x is equal to 0
            while (x != 0)
            {
                // get the remainder
                int remainder = x % 10;
                // truncate the integer
                x /= 10;

                try
                {
                    // flip the given integer
                    result = checked(remainder + result * 10);
                }
                // if the integer is over int32, return 0
                catch (System.OverflowException)
                {
                    return 0;
                }
                
            }
            return result;
        }
    }
}

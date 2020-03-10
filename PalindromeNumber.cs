using System;

namespace LeetCode9
{
    class Program
    {
        static void Main(string[] args)
        {
            int given = 121;
            Console.WriteLine(IsPalindrome(given));
        }
        public static bool IsPalindrome(int x)
        {
            // store original value of x
            int givenInt = x;
            int result = 0;

            // if x is negative return false
            // if x is greater then 0 but multiple of 10, return false
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            while (x > 0)
            {
                // get the remainder + add zero to the back of result
                // result = 1 + 0
                // 1 = 2 + 10 and so on
                result = x % 10 + result * 10;
                // truncate the last number from the integer
                // x = 121 / 10 = 12 and so on
                x /= 10;
            }
            // if equal return true else false
            return givenInt == result;
        }
    }
}

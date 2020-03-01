using System;

namespace singleDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            /* break given integer, add them, if sum is single digit return esle break again */
            Console.WriteLine(string.Join(" ", singleDigitSum(0)));
        }

        public static int singleDigitSum(int x)
        {
            int sum = 0;
            int check = 10;

            while (check > 9)
            {
                sum = 0;
                while (x > 0)
                {
                    sum = x % 10 + sum;
                    x = x / 10;
                }
                x = sum;
                check = sum;
            }
            return sum;

        }
    }
}

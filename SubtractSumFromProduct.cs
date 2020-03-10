using System;

namespace LeetCode1281
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = 234;
            Console.WriteLine(SubtractSumFromProduct(integer).ToString()); ;
        }
        public static int SubtractSumFromProduct(int n)
        {
            // holds prudoct of int
            int product = 1;
            // holds sum of int
            int sum = 0;

            while (n > 0)
            {
                // drop one number at a time and multiply
                product = n % 10 * product;
                // drop one number at a time and add
                sum = n % 10 + sum;
                // take out the number thats been used above
                n /= 10;
            }

            return product - sum;
        }
    }
}

using System;

namespace ReduceNumberToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = NumberOfSteps(123);
            Console.WriteLine(result.ToString());

        }
        public static int NumberOfSteps(int num)
        {
            int count = 0;

            while (num > 0)
            {
                // if even
                if (num % 2 == 0)
                {
                    // divide the number by 2
                    num /= 2;
                    count += 1;
                }
                // if odd
                else
                {
                    // substract 1
                    num -= 1;
                    count += 1;
                }
            }
            // return total number of steps
            return count;

        }
    }
}

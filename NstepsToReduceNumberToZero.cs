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
                if (num % 2 == 0)
                {
                    num = num / 2;
                    count += 1;
                }
                else
                {
                    num = num - 1;
                    count += 1;
                }
            }
            return count;

        }
    }
}

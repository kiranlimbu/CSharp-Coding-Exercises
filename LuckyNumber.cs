using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbersMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] given = {

                new int[] {1,10, 4, 2},
                new int[] {9,3,8,7},
                new int[] {15,16,17,12}

            };

            Console.WriteLine(string.Join(" ", LuckyNumbers(given)));

            Console.ReadLine();
        }
        public static IList<int> LuckyNumbers(int[][] matrix)
        {
            List<int> maxCol = new List<int>() { };
            List<int> lucky = new List<int>() { };

            // find max in the column
            for (int col = 0; col < matrix[0].Length; col++)
            {
                int x = 0;
                for (int row = 0; row < matrix.Length; row++)
                {
                    x = Math.Max(matrix[row][col], x);
                }
                maxCol.Add(x);
            }

            // find min in the row
            for (int i = 0; i < matrix.Length; i++)
            {
                if (maxCol.Contains(matrix[i].Min()))
                {
                    lucky.Add(matrix[i].Min());
                }
            }
            return lucky;

        }
    }
}

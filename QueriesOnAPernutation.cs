using System;
using System.Collections.Generic;

namespace _5381
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] queries = { 3, 1, 2, 1 };
            Console.WriteLine(string.Join(" ", ProcessQueries(queries, 5)));
        }

        public static int[] ProcessQueries(int[] queries, int m)
        {
            List<int> target = new List<int>();
            List<int> idx = new List<int>();

            for (int i=0; i<m; i++)
            {
                idx.Insert(i, i+1);
            }

            for (int j=0; j<queries.Length; j++)
            {
                int location = idx.IndexOf(queries[j]);
              
                idx.Remove(queries[j]);
               
                target.Add(location);
                idx.Insert(0, queries[j]);
            }
            return target.ToArray();
        }
    }
}

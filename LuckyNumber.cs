using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode5368
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 19,12,11,14,18,8,6,6,13,9,8,3,10,10,1,10,5,12,13,13,9 };

            Console.WriteLine(FindLucky(arr));
        }

        public static int FindLucky(int[] arr)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            var sort = from item in dict orderby item.Value descending select item;

            int lucky = -1;
            foreach (KeyValuePair<int, int> item in sort)
            {
                if (item.Key == item.Value)
                {
                    return item.Key;
                }
            }
            return lucky;
        }
    }
}

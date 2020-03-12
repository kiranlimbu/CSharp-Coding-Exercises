using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, -5, 7, 8, 0, 3, 6, 1 };
            SelectorSort(arr);

            Console.ReadLine();
        }
        static void SelectorSort(int[] lst)
        {
            int n = lst.Length;
            int i, j, small, temp;

            for (i = 0; i < n; i++)
            {
                small = lst[i];

                for (j = i+1; j < n; j++)
                {
                    if (small > lst[j]) // if small is bigger then current number
                    {
                        small = lst[j]; // fill small value with current number
                        temp = lst[i]; // put i value in temp
                        lst[i] = small; // fill i with new found small
                        lst[j] = temp; // fill j with old i value
                    }
                }  
            }

            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }

        }
    }
}

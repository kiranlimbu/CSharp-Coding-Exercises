using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RankTeamsByVote
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] given = { "WXYZ", "XYZW" };
            Console.WriteLine(string.Join(" ", RankTeams(given)));
        }

        public static string RankTeams(string[] votes)
        {

            // separate element from array
            Dictionary<char, int[]> character = new Dictionary<char, int[]>();
            // initialize array for each character
            foreach (char c in votes[0])
            {
                character[c] = new int[votes[0].Length];
            }
            
            // Add/count number of times the team appear in that position
            foreach (string vote in votes)
            {
                for (int i= 0; i<vote.Length; i++)
                {
                    character[vote[i]][i]++;
                }
            }

            var lst = character.ToList(); // store[w, [1,0,0,1]] [x, [1,1,0,0]] [y, [0,1,1,0]] [z, [0,0,1,1]]

            // sort List
            lst.Sort((a, b) =>
            {
                for (int i = 0; i < a.Value.Length; i++)
                {
                    // compare two character at a time
                    // if value is equal more to next column
                    // pick the character with higher value
                    if (a.Value[i] != b.Value[i]) // a b changes from x w, y w, z y 
                    {
                        return b.Value[i] - a.Value[i]; // returns -1, 1, 1                     
                    }
                }
                return a.Key - b.Key;
            });

            // at this point List is sorted
            char[] arr = lst.Select(a => a.Key).ToArray();
            return new string(arr);
        }
    }
}

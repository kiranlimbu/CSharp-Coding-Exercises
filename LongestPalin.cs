using System;

namespace LeetCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "sfasfafjjabcdeedcba"; // sfasfafjjabcdeedcba
            Console.WriteLine(LongestPalindrome(s));
        }

        // did not work
        //public static string LongestPalindrome(string s)
        //{
        //    int n = s.Length;

        //    Dictionary<int, char> res2 = new Dictionary<int, char>();
        //    Dictionary<int, char> res1 = new Dictionary<int, char>();

        //    if (n <= 0 || n == 1) return s;
        //    if (n == 2 && s[0] == s[1]) return s;
        //    else if (n == 2 && s[0] != s[1]) return s[0].ToString();

        //    for (int i=0; i<n-1; i++)
        //    {
        //        int orgVal = i; // original value of i
        //        int j = n - 1; // j = last index in array

        //        while (i < j)
        //        {
        //            if (s[i] == s[j])
        //            {
        //                res2[i] = s[i];
        //                res2[j] = s[j];
        //                if (j - i == 2)
        //                {
        //                    res2[i + 1] = s[i + 1];
        //                    break;
        //                }

        //                i++;
        //                j--;
        //            }
        //            else
        //            {
        //                res2.Clear();
        //                i = orgVal;
        //                j--;
        //            }                   
        //        }

        //        if (res2.Count > res1.Count)
        //        {
        //            res1 = new Dictionary<int, char>(res2);
        //        }

        //        // reset to original value
        //        res2.Clear();
        //        i = orgVal;
        //    }
        //    // check for zero palindrome
        //    if (res1.Count == 0) return s[0].ToString();
        //    // sort
        //    var result = from item in res1 orderby item.Key select item.Value;

        //    // conert to string
        //    string palindrome = "";
        //    foreach (var item in result)
        //    {
        //        palindrome += item;
        //    }

        //    return palindrome;
        //}

        public static string LongestPalindrome(string s)
        {
            if (s.Length == 0) return s;

            int newMaxLength = 0;
            int left = 0;

            for (int i=0; i<s.Length; i++)
            {
                int result1 = ExpandFromMiddle(s, i, i); // edge case "abgba"
                int result2 = ExpandFromMiddle(s, i, i+1); // edge case "abbc"
                int maxLength = Math.Max(result1, result2); // get max length

                if (maxLength > newMaxLength)
                {
                    newMaxLength = maxLength;
                    left = i - ((newMaxLength) / 2);
                }  
            }

            return s.Substring(left, newMaxLength+1); // newMaxLength is zeroed index value, to return true length add 1
        }

        public static int ExpandFromMiddle(string s, int left, int right)
        {
            // start from index i and expand out
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            int length = (right-1) - (left+1); // neutralize extra steps it takes while exiting out of while loop

            return length; // length gives zeroed index value
        }
    }
}

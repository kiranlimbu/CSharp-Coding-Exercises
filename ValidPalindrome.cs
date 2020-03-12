using System;
using System.Threading;

namespace LeetCode125
{
    class ValidPalindrome
    {
        static void Main(string[] args)
        {
            string given = "A man, a plan, a canal: Panama";
            Console.WriteLine(IsPalindrome1(given));
        }
        public static bool IsPalindrome(string s)
        {

            string phrase = s.ToLower();
            string alphabet = "abcdefghijklmnopqrstuvwxyz01234556789";
            string characters = "";

            if (phrase.Length < 2) { return true; }
            // only accepts alphabet and digits
            for (int i = 0; i < phrase.Length; i++)
            {
                if (alphabet.Contains(phrase[i]))
                {
                    characters += phrase[i];
                }
            }
            // check if first and last value match
            int n = characters.Length;
            for (int i = 0; i < n; i++)
            {
                if (characters[i] != characters[n - 1])
                {
                    return false;
                }
                else
                {
                    n -= 1;
                }
            }
            return true;
        }
        // faster version
        public static bool IsPalindrome1(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            // front pointer
            int start = 0;
            // back pointer
            int end = s.Length - 1;
            while (start <= end)
            {
                // from front, separate alphabets/digits
                while (start <= end && !Char.IsLetterOrDigit(s[start]))
                {
                    start++;
                }
                // from back, separate alphabets/digits
                while (end >= start && !Char.IsLetterOrDigit(s[end]))
                {
                    end--;
                }
                Console.WriteLine("start: {0}", start);
                Console.WriteLine(Char.IsLetterOrDigit(s[start]));
                Thread.Sleep(2000);

                // check first and last value and move inword
                if (start <= end && Char.ToLower(s[start]) != Char.ToLower(s[end]))
                {
                    return false;
                }
                // move inword
                start++;
                end--;
            }
            return true;
        }
    }
}

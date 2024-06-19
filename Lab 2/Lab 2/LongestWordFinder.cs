using System;

namespace Lab2
{
    class LongestWordFinder
    {
        public static string FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}
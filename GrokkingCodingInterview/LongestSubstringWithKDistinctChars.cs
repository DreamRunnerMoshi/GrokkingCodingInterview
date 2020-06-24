using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace SlidingWindow
{
    public class LongestSubstringWithKDistinctChars
    {
        public int GetLongestSubstringLength(string input, int k)
        {
            int windowStart = 0;
            int windowEnd = 0;
            var dictionary = new Dictionary<char, int>();
            int maxSize = int.MinValue;
            while (windowEnd < input.Length)
            {

                char c = input[windowEnd];
                if (!dictionary.ContainsKey(c))
                {
                    dictionary[c] = 0;
                }
                dictionary[c]++;

                while (dictionary.Keys.Count > k)
                {
                    var startChar = input[windowStart++];
                    dictionary[startChar]--;
                    if (dictionary[startChar] == 0)
                    {
                        dictionary.Remove(startChar);
                    }
                }
                maxSize = Math.Max(windowEnd - windowStart + 1, maxSize);
                windowEnd++;
            }
            return maxSize;
        }
    }
}

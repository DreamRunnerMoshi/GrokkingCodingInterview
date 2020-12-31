using System;
using System.Collections.Generic;

namespace SlidingWindow
{

    /// <summary>
    /// By this algorithm
    /// https://leetcode.com/problems/max-consecutive-ones-iii/
    /// </summary>
    public class LngstSubWithSameLetterAfterRplcmnt
    {
        public int GetLongestSubstringLength(string input, int k)
        {
            int windowStart = 0;
            int windowEnd = 0;
            int maxLength = int.MinValue;

            var letterFrequency = new Dictionary<char, int>();
            int maxRepetingCount = 0;

            while (windowEnd < input.Length)
            {
                var endChar = input[windowEnd];

                if (!letterFrequency.ContainsKey(endChar))
                {
                    letterFrequency[endChar] = 0;
                }
                letterFrequency[endChar]++;

                maxRepetingCount = Math.Max(maxRepetingCount, letterFrequency[endChar]);

                if (windowEnd - windowStart - maxRepetingCount + 1 > k)
                {
                    var startChar = input[windowStart];
                    letterFrequency[startChar]--;
                    windowStart++;
                }

                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
                windowEnd++;
            }

            return maxLength;
        }
    }
}

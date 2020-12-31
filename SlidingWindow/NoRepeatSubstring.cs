using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindow
{
    public class NoRepeatSubstring
    {
        public int GetMaxSubstringLength(string input)
        {
            int widowStart = 0;
            int windowEnd = 0;
            var hashSet = new HashSet<char>();
            int maxLength = int.MinValue;

            while (windowEnd < input.Length)
            {
                var endChar = input[windowEnd];
                if (hashSet.Contains(endChar))
                {
                    maxLength = Math.Max(hashSet.Count, maxLength);
                    while (hashSet.Contains(endChar))
                    {
                        var startChar = input[widowStart++];
                        hashSet.Remove(startChar);
                    }
                }
                hashSet.Add(endChar);

                windowEnd++;
            }

            return maxLength;
        }

        public int GetMaxSubstringLengthMoreEfficient(string input)
        {
            int windowStart = 0;
            int windowEnd = 0;
            var charIndexMap = new Dictionary<char, int>();
            int maxLength = int.MinValue;

            while (windowEnd < input.Length)
            {
                var endChar = input[windowEnd];
                if (charIndexMap.ContainsKey(endChar))
                {
                    //if we found a character duplicate at any index greater than current
                    //windowStart, so need to move 1 index from start. We can jump to 
                    //
                    windowStart = Math.Max(windowStart, charIndexMap[endChar] + 1);
                }

                charIndexMap[endChar] = windowEnd;
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
                windowEnd++;
            }

            return maxLength;
        }
    }
}

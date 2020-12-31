using System;
using System.Collections.Generic;

namespace SlidingWindow
{
    public class FruitsIntoBaskets
    {
        public int GetMaxCount(char[] array)
        {
            int k = 2;
            int windowStart = 0;
            int windowEnd = 0;
            var dictionary = new Dictionary<char, int>();
            int maxSize = int.MinValue;

            while (windowEnd < array.Length)
            {
                char c = array[windowEnd];
                if (!dictionary.ContainsKey(c))
                {
                    dictionary[c] = 0;
                }
                dictionary[c]++;

                while (dictionary.Keys.Count > k)
                {
                    var startChar = array[windowStart++];
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

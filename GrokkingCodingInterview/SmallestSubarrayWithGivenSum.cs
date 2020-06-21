using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindow
{
    public class SmallestSubarrayWithGivenSum
    {
        public int GetSmallestSubarrayElementCount(int[] array, int sum)
        {
            int minLength = int.MaxValue;

            int windowStart = 0;
            int windowEnd = 0;
            float windowSum = 0;
            while (windowEnd < array.Length)
            {
                windowSum += array[windowEnd];

                while (windowSum >= sum)
                {
                    windowSum -= array[windowStart];
                    int windowSize = windowEnd - windowStart + 1;
                    minLength = Math.Min(windowSize, minLength);
                    windowStart++;
                }

                windowEnd++;
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindow
{
    public class AverageOfContiguousSubarraySizeK
    {
        public float[] GetAverage(int[] array, int k)
        {
            var result = new float[array.Length - k + 1];
            int windowStart = 0;
            int windowEnd = 0;
            float windowSum = 0;
            while (windowEnd < array.Length)
            {
                windowSum += array[windowEnd];
                if (windowEnd >= k-1)
                {
                    result[windowStart] = windowSum / k;
                    windowSum -= array[windowStart];
                    windowStart++;
                }

                windowEnd++;
            }

            return result;
        }
    }
}

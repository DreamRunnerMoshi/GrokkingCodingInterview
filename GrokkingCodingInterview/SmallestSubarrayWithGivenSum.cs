﻿using System;

namespace SlidingWindow
{

    ///<summary>
    ///Time Complexity #
    ///The time complexity of the above algorithm will be O(N). 
    ///The outer for loop runs for all elements and the inner while loop processes each element only once, 
    ///therefore the time complexity of the algorithm will be O(N+N) which is asymptotically equivalent to O(N).
    ///Space Complexity #
    ///The algorithm runs in constant space O(1).
    /// </summary>
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


/// <summary>
/// https://leetcode.com/problems/grumpy-bookstore-owner/
/// Small improvement needed
/// </summary>

namespace SlidingWindow
{
    public class MaximumSumSubarraySizeK
    {
        public int GetMaxSum(int[] array, int k)
        {
            var maxSum = int.MinValue;
            int windowStart = 0;
            int windowEnd = 0;
            int windowSum = 0;
            while (windowEnd < array.Length)
            {
                windowSum += array[windowEnd];
                if (windowEnd >= k - 1)
                {
                    if (windowSum > maxSum) maxSum = windowSum;

                    windowSum -= array[windowStart];
                    windowStart++;
                }

                windowEnd++;
            }

            return maxSum;
        }
    }
}

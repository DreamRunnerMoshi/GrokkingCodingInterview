using SlidingWindow;
using System;
using Xunit;

namespace SlidingWindowTestProject
{
    public class AverageOfContiguousSubarraySizeKTests
    {
        private AverageOfContiguousSubarraySizeK averageOfContiguousSubarraySizeK;
        public AverageOfContiguousSubarraySizeKTests()
        {
            averageOfContiguousSubarraySizeK = new AverageOfContiguousSubarraySizeK();
        }

        [Fact]
        public void AverageOfContiguousSubarraySizeK_ReturnTrue()
        {
            var array = new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 };
            int k = 5;
            var actual = averageOfContiguousSubarraySizeK.GetAverage(array, k);
            var expected = new float[] { 2.2f, 2.8f, 2.4f, 3.6f, 2.8f };
            Assert.Equal(actual, expected);
        }
    }
}

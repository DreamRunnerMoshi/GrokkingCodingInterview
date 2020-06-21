using SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SlidingWindowTestProject
{
    public class MaximumSumSubarraySizeKTests
    {
        private MaximumSumSubarraySizeK  maximumSumSubarraySizeK;
        public MaximumSumSubarraySizeKTests()
        {
            maximumSumSubarraySizeK = new MaximumSumSubarraySizeK();
        }

        [Fact]
        public void MaximumSumSubarraySizeK_Positive1()
        {
            var array = new int []{2, 1, 5, 1, 3, 2 };
            int k=3 ;
            var actual = maximumSumSubarraySizeK.GetMaxSum(array,k);
            var expected = 9;
            Assert.Equal(actual,expected);
        }


        [Fact]
        public void MaximumSumSubarraySizeK_Positive2()
        {
            var array = new int[] { 2, 3, 4, 1, 5 };
            int k = 2;
            var actual = maximumSumSubarraySizeK.GetMaxSum(array, k);
            var expected = 7;
            Assert.Equal(actual, expected);
        }
    }
}

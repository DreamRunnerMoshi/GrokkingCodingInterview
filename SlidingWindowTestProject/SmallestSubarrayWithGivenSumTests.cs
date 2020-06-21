using SlidingWindow;
using Xunit;

namespace SlidingWindowTestProject
{
    public class SmallestSubarrayWithGivenSumTests
    {
        private SmallestSubarrayWithGivenSum smallestSubarrayWithGivenSum;
        public SmallestSubarrayWithGivenSumTests()
        {
            smallestSubarrayWithGivenSum = new SmallestSubarrayWithGivenSum();
        }

        [Fact]
        public void GetSmallestSubarrayElementCount_Positive1()
        {
            var array = new int[] { 2, 1, 5, 2, 3, 2 };
            int sum = 7;

            var actual = smallestSubarrayWithGivenSum.GetSmallestSubarrayElementCount(array, sum);
            var expected = 2;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void GetSmallestSubarrayElementCount_Positive2()
        {
            var array = new int[] { 2, 1, 5, 2, 8 };
            int sum = 7;

            var actual = smallestSubarrayWithGivenSum.GetSmallestSubarrayElementCount(array, sum);
            var expected = 1;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void GetSmallestSubarrayElementCount_Positive3()
        {
            var array = new int[] { 3, 4, 1, 1, 6 };
            int sum = 8;

            var actual = smallestSubarrayWithGivenSum.GetSmallestSubarrayElementCount(array, sum);
            var expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSmallestSubarrayElementCount_Positive4()
        {
            var array = new int[] { 3, 4, 1, 1, 6 };
            int sum = 80;

            var actual = smallestSubarrayWithGivenSum.GetSmallestSubarrayElementCount(array, sum);
            var expected = 0;
            Assert.Equal(expected, actual);
        }
    }
}

using SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SlidingWindowTestProject
{
    public class LongestSubstringWithKDistinctCharsTests
    {
        readonly LongestSubstringWithKDistinctChars longestSubstringWithKDistinctChars;
        public LongestSubstringWithKDistinctCharsTests()
        {
            longestSubstringWithKDistinctChars = new LongestSubstringWithKDistinctChars();
        }

        [Fact]
        public void LongestSubstringWithKDistinctChars_Positive()
        {
            String input = "araaci";
            int k = 2;

            var actual = longestSubstringWithKDistinctChars.GetLongestSubstringLength(input, k);
            var expected = 4;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LongestSubstringWithKDistinctChars_PositiveK1()
        {
            String input = "araaci";
            int k = 1;

            var actual = longestSubstringWithKDistinctChars.GetLongestSubstringLength(input, k);
            var expected = 2;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LongestSubstringWithKDistinctChars_PositiveK0()
        {
            String input = "araaci";
            int k = 0;

            var actual = longestSubstringWithKDistinctChars.GetLongestSubstringLength(input, k);
            var expected = 0;
            Assert.Equal(expected, actual);
        }
    }
}

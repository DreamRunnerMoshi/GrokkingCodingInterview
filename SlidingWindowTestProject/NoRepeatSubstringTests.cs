using SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SlidingWindowTestProject
{
    public class NoRepeatSubstringTests
    {
        private NoRepeatSubstring noRepeat;

        public NoRepeatSubstringTests()
        {
            noRepeat = new NoRepeatSubstring();
        }

        [Fact]
        public void NoRepeatSubstring_Positive()
        {
            var input = "aabccbb";
            var actual = noRepeat.GetMaxSubstringLength(input);
            var expected = 3;

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void NoRepeatSubstring_Positive1()
        {
            var input = "abccde";
            var actual = noRepeat.GetMaxSubstringLength(input);
            var expected = 3;

            Assert.Equal(expected, actual);
        }
    }
}

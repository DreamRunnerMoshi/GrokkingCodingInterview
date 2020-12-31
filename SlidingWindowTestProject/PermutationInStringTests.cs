using SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SlidingWindowTestProject
{
    public class PermutationInStringTests
    {
        private PermutationInString pis;

        public PermutationInStringTests()
        {
            pis = new PermutationInString();
        }

        [Fact]
        public void PermutationInString_Positive()
        {
            var input = "oidbcaf";
            var pattern = "abc";

            var actual = pis.IsPermutationContains(input, pattern);
            var expected = true;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PermutationInString_NotFound()
        {
            var input = "odicf";
            var pattern = "dc";

            var actual = pis.IsPermutationContains(input, pattern);
            var expected = false;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PermutationInString_SameInputAndPattern()
        {
            var input = "bcdxabcdy";
            var pattern = "bcdyabcdx";

            var actual = pis.IsPermutationContains(input, pattern);
            var expected = true;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PermutationInString_Notfound2()
        {
            var input = "ooolleoooleh"; ;
            var pattern = "hello";


            var actual = pis.IsPermutationContains(input, pattern);
            var expected = false;

            Assert.Equal(expected, actual);
        }
    }
}

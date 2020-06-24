using SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SlidingWindowTestProject
{
    public class FruitsIntoBasketsTests
    {
        readonly FruitsIntoBaskets fruitsIntoBaskets;
        public FruitsIntoBasketsTests()
        {
            fruitsIntoBaskets = new FruitsIntoBaskets();
        }


        [Fact]
        public void FruitsIntoBaskets_Positive()
        {
            var array = new char[] { 'A', 'B', 'C', 'A', 'C' };
            var actual = fruitsIntoBaskets.GetMaxCount(array);
            var expected = 3;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void FruitsIntoBaskets_Positive1()
        {
            var array = new char[] { 'A', 'B', 'C', 'B', 'B', 'C' };
            var actual = fruitsIntoBaskets.GetMaxCount(array);
            var expected = 5;
            Assert.Equal(actual, expected);
        }
    }
}

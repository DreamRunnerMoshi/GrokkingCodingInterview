using SlidingWindow;
using Xunit;

namespace SlidingWindowTestProject
{
    public class LngstSubWithSameLetterAfterRplcmntTests
    {
        private LngstSubWithSameLetterAfterRplcmnt lng;

        public LngstSubWithSameLetterAfterRplcmntTests()
        {
            lng = new LngstSubWithSameLetterAfterRplcmnt();
        }

        [Fact]
        public void LngstSubWithSameLetterAfterRplcmnt_Positive()
        {
            var input = "aabccbb";
            int k = 2;
            var actual = lng.GetLongestSubstringLength(input,k);
            var expected = 5;

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void LngstSubWithSameLetterAfterRplcmnt_Positive1()
        {
            var input = "aabbab";
            int k = 2;
            var actual = lng.GetLongestSubstringLength(input, k);
            var expected = 5;

            Assert.Equal(expected, actual);
        }
    }
}

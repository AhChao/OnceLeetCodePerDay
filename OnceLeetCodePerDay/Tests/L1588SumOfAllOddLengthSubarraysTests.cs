using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
    public class L1588SumOfAllOddLengthSubarraysTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1588SumOfAllOddLengthSubarrays = new L1588SumOfAllOddLengthSubarrays();
        }

        private L1588SumOfAllOddLengthSubarrays _l1588SumOfAllOddLengthSubarrays;
        private int[] _arr;

        [Test]
        public void Example1_Should_Return_58()
        {
            _arr = new[] {1, 4, 2, 5, 3};
            ResultShouldBe(58);
        }

        [Test]
        public void Example2_Should_Return_3()
        {
            _arr = new[] {1, 2};
            ResultShouldBe(3);
        }

        [Test]
        public void Example3_Should_Return_66()
        {
            _arr = new[] {10, 11, 12};
            ResultShouldBe(66);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1588SumOfAllOddLengthSubarrays.SumOddLengthSubarrays(_arr));
        }
    }
}
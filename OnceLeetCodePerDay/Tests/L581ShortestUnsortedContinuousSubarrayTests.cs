using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/shortest-unsorted-continuous-subarray/
    public class L581ShortestUnsortedContinuousSubarrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l581ShortestUnsortedContinuousSubarray = new L581ShortestUnsortedContinuousSubarray();
        }

        private L581ShortestUnsortedContinuousSubarray _l581ShortestUnsortedContinuousSubarray;
        private int[] _nums;

        [Test]
        public void Example1_Should_Return_5()
        {
            _nums = new[] {2, 6, 4, 8, 10, 9, 15};
            ResultShouldBe(5);
        }


        [Test]
        public void Example2_Should_Return_0()
        {
            _nums = new[] {1, 2, 3, 4};
            ResultShouldBe(0);
        }


        [Test]
        public void Example3_Should_Return_0()
        {
            _nums = new[] {1};
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l581ShortestUnsortedContinuousSubarray.FindUnsortedSubarray(_nums));
        }
    }
}
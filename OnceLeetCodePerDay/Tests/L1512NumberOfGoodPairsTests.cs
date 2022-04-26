using NUnit.Framework;
using OnceLeetCodePerDay.I;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/number-of-good-pairs/
    public class L1512NumberOfGoodPairsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1512NumberOfGoodPairs = new L1512NumberOfGoodPairs();
        }

        private L1512NumberOfGoodPairs _l1512NumberOfGoodPairs;
        private int[] _nums;

        [Test]
        public void Input_123113_Result_Should_Be_4()
        {
            _nums = new[] {1, 2, 3, 1, 1, 3};
            ResultShouldBe(4);
        }

        [Test]
        public void Input_1111_Result_Should_Be_6()
        {
            _nums = new[] {1, 1, 1, 1};
            ResultShouldBe(6);
        }


        [Test]
        public void Input_123_Result_Should_Be_0()
        {
            _nums = new[] {1, 2, 3};
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1512NumberOfGoodPairs.NumIdenticalPairs(_nums));
        }
    }
}
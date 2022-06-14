using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/maximum-erasure-value/
    public class L1695MaximumErasureValueTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1695MaximumErasureValue = new L1695MaximumErasureValue();
        }

        private L1695MaximumErasureValue _l1695MaximumErasureValue;
        private int[] _nums;

        [Test]
        public void Example1_Should_Be_17()
        {
            _nums = new[] {4, 2, 4, 5, 6};
            ResultShouldBe(17);
        }

        [Test]
        public void Example2_Should_Be_8()
        {
            _nums = new[] {5, 2, 1, 2, 5, 2, 1, 2, 5};
            ResultShouldBe(8);
        }

        [Test]
        public void Example3_Should_Be_16911()
        {
            _nums = new[]
                    {
                        187, 470, 25, 436, 538, 809, 441, 167, 477, 110, 275, 133, 666, 345, 411, 459, 490, 266,
                        987, 965, 429, 166, 809, 340, 467, 318, 125, 165, 809, 610, 31, 585, 970, 306, 42, 189,
                        169, 743, 78, 810, 70, 382, 367, 490, 787, 670, 476, 278, 775, 673, 299, 19, 893, 817,
                        971, 458, 409, 886, 434
                    };
            ResultShouldBe(16911);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1695MaximumErasureValue.MaximumUniqueSubarray(_nums));
        }
    }
}
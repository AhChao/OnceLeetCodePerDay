using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/132-pattern/
    public class L456_132PatternTests
    {
        [SetUp]
        public void SetUp()
        {
            _l456132Pattern = new L456_132Pattern();
        }

        private L456_132Pattern _l456132Pattern;
        private int[] _nums;

        [Test]
        public void Input_1234_Should_Return_False()
        {
            _nums = new[] {1, 2, 3, 4};
            ResultShouldBe(false);
        }

        [Test]
        public void Input_3142_Should_Return_True()
        {
            _nums = new[] {3, 1, 4, 2};
            ResultShouldBe(true);
        }

        [Test]
        public void Input_n1320_Should_Return_True()
        {
            _nums = new[] {-1, 3, 2, 0};
            ResultShouldBe(true);
        }

        [Test]
        public void Input_n212n212_Should_Return_True()
        {
            _nums = new[] {-2, 1, 2, -2, 1, 2};
            ResultShouldBe(true);
        }

        [Test]
        public void Input_35034_Should_Return_True()
        {
            _nums = new[] {3, 5, 0, 3, 4};
            ResultShouldBe(true);
        }

        [Test]
        public void Input_101n4n3_Should_Return_False()
        {
            _nums = new[] {1, 0, 1, -4, -3};
            ResultShouldBe(false);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l456132Pattern.Find132pattern(_nums));
        }
    }
}
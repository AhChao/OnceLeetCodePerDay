using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/construct-target-array-with-multiple-sums/
    public class L1354ConstructTargetArrayWithMultipleSumsTests
    {
        private L1354ConstructTargetArrayWithMultipleSums _l1354ConstructTargetArrayWithMultipleSums;
        private int[] _target;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l1354ConstructTargetArrayWithMultipleSums = new L1354ConstructTargetArrayWithMultipleSums();
            _target = new[] {9, 3, 5};
            ResultShouldBe(true);
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l1354ConstructTargetArrayWithMultipleSums = new L1354ConstructTargetArrayWithMultipleSums();
            _target = new[] {1, 1, 1, 2};
            ResultShouldBe(false);
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _l1354ConstructTargetArrayWithMultipleSums = new L1354ConstructTargetArrayWithMultipleSums();
            _target = new[] {8, 5};
            ResultShouldBe(true);
        }

        [Test]
        public void Example4_Should_Return_As_Expected()
        {
            _l1354ConstructTargetArrayWithMultipleSums = new L1354ConstructTargetArrayWithMultipleSums();
            _target = new[] {1, 1, 2};
            ResultShouldBe(false);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l1354ConstructTargetArrayWithMultipleSums.IsPossible(_target));
        }
    }
}
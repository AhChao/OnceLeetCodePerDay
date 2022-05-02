using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
    public class L1365HowManyNumbersAreSmallerThanTheCurrentNumberTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1365HowManyNumbersAreSmallerThanTheCurrentNumber =
                new L1365HowManyNumbersAreSmallerThanTheCurrentNumber();
        }

        private L1365HowManyNumbersAreSmallerThanTheCurrentNumber _l1365HowManyNumbersAreSmallerThanTheCurrentNumber;
        private int[] _nums;

        [Test]
        public void Input_81223_Should_Return_40113()
        {
            _nums = new[] {8, 1, 2, 2, 3};
            ResultShouldBe(new[] {4, 0, 1, 1, 3});
        }

        [Test]
        public void Input_6548_Should_Return_2103()
        {
            _nums = new[] {6, 5, 4, 8};
            ResultShouldBe(new[] {2, 1, 0, 3});
        }

        [Test]
        public void Input_7777_Should_Return_0000()
        {
            _nums = new[] {7, 7, 7, 7};
            ResultShouldBe(new[] {0, 0, 0, 0});
        }

        private void ResultShouldBe(int[] expectation)
        {
            _l1365HowManyNumbersAreSmallerThanTheCurrentNumber.SmallerNumbersThanCurrent(_nums).Should()
                                                              .Equal(expectation);
        }
    }
}
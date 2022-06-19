using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/n-repeated-element-in-size-2n-array/
    public class L961NRepeatedElementInSize2NArrayTests
    {
        private L961NRepeatedElementInSize2NArray _l961NRepeatedElementInSize2NArray;
        private int[] _nums;

        [Test]
        public void Example1_Should_Return_3()
        {
            _l961NRepeatedElementInSize2NArray = new L961NRepeatedElementInSize2NArray();
            _nums = new[] {1, 2, 3, 3};
            ResultShouldBe(3);
        }

        [Test]
        public void Example2_Should_Return_2()
        {
            _l961NRepeatedElementInSize2NArray = new L961NRepeatedElementInSize2NArray();
            _nums = new[] {2, 1, 2, 5, 3, 2};
            ResultShouldBe(2);
        }

        [Test]
        public void Example3_Should_Return_5()
        {
            _l961NRepeatedElementInSize2NArray = new L961NRepeatedElementInSize2NArray();
            _nums = new[] {5, 1, 5, 2, 5, 3, 5, 4};
            ResultShouldBe(5);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l961NRepeatedElementInSize2NArray.RepeatedNTimes(_nums));
        }
    }
}
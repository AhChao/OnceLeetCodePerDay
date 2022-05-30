using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/maximum-product-difference-between-two-pairs/
    public class L1913MaximumProductDifferenceBetweenTwoPairsTests
    {
        private L1913MaximumProductDifferenceBetweenTwoPairs _l1913MaximumProductDifferenceBetweenTwoPairs;
        private int[] _nums;

        [Test]
        public void Example1_Should_Return_Result_6m7_minus_2m4()
        {
            _l1913MaximumProductDifferenceBetweenTwoPairs = new L1913MaximumProductDifferenceBetweenTwoPairs();
            _nums = new[] {5, 6, 2, 7, 4};
            ResultShouldBe(6 * 7 - 2 * 4);
        }

        [Test]
        public void Example2_Should_Return_Result_9m8_minus_2m4()
        {
            _l1913MaximumProductDifferenceBetweenTwoPairs = new L1913MaximumProductDifferenceBetweenTwoPairs();
            _nums = new[] {4, 2, 5, 9, 7, 4, 8};
            ResultShouldBe(9 * 8 - 2 * 4);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1913MaximumProductDifferenceBetweenTwoPairs.MaxProductDifference(_nums));
        }
    }
}
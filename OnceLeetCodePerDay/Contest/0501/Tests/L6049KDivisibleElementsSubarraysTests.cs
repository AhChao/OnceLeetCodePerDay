using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0501.Implement;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/weekly-contest-291/problems/k-divisible-elements-subarrays/
    //https://leetcode.com/problems/k-divisible-elements-subarrays/
    public class L6049KDivisibleElementsSubarraysTests
    {
        [SetUp]
        public void SetUp()
        {
            _l6049KDivisibleElementsSubarrays = new L6049KDivisibleElementsSubarrays();
        }

        private L6049KDivisibleElementsSubarrays _l6049KDivisibleElementsSubarrays;
        private int[] _nums;
        private int _k;
        private int _p;

        [Test]
        public void Input_23322_2_2_Result_Should_Be_11()
        {
            _nums = new[] {2, 3, 3, 2, 2};
            _k = 2;
            _p = 2;
            ResultShouldBe(11);
        }

        [Test]
        public void Input_1234_4_1_Result_Should_Be_10()
        {
            _nums = new[] {1, 2, 3, 4};
            _k = 4;
            _p = 1;
            ResultShouldBe(10);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l6049KDivisibleElementsSubarrays.CountDistinct(_nums, _k, _p));
        }
    }
}
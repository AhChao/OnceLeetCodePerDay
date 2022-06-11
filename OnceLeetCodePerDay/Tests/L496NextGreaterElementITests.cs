using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/next-greater-element-i/
    public class L496NextGreaterElementITests
    {
        [SetUp]
        public void SetUp()
        {
            _l496NextGreaterElementI = new L496NextGreaterElementI();
        }

        private L496NextGreaterElementI _l496NextGreaterElementI;
        private int[] _nums1;
        private int[] _nums2;
        private int[] _expected;

        [Test]
        public void Example1_Should_Be_As_Expected()
        {
            _nums1 = new[] {4, 1, 2};
            _nums2 = new[] {1, 3, 4, 2};
            _expected = new[] {-1, 3, -1};
            CheckTheResult();
        }

        [Test]
        public void Example2_Should_Be_As_Expected()
        {
            _nums1 = new[] {2, 4};
            _nums2 = new[] {1, 2, 3, 4};
            _expected = new[] {3, -1};
            CheckTheResult();
        }

        private void CheckTheResult()
        {
            _l496NextGreaterElementI.NextGreaterElement(_nums1, _nums2).Should()
                                    .BeEquivalentTo(_expected, rules => rules.WithStrictOrdering());
        }
    }
}
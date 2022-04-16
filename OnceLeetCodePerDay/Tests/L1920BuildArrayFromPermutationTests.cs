using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/build-array-from-permutation/
    public class L1920BuildArrayFromPermutationTests
    {
        private L1920BuildArrayFromPermutation _l1920BuildArrayFromPermutation;
        private int[] _input;

        [Test]
        public void Result_Of_021534_Should_Be_012453()
        {
            _l1920BuildArrayFromPermutation = new L1920BuildArrayFromPermutation();
            _input = new[] {0, 2, 1, 5, 3, 4};
            BuildArrayResultShouldBe(new[] {0, 1, 2, 4, 5, 3});
        }

        [Test]
        public void Result_Of_501234_Should_Be_450123()
        {
            _l1920BuildArrayFromPermutation = new L1920BuildArrayFromPermutation();
            _input = new[] {5, 0, 1, 2, 3, 4};
            BuildArrayResultShouldBe(new[] {4, 5, 0, 1, 2, 3});
        }

        private void BuildArrayResultShouldBe(int[] expected)
        {
            _l1920BuildArrayFromPermutation.BuildArray(_input).Should()
                                           .Equal(expected);
        }
    }
}
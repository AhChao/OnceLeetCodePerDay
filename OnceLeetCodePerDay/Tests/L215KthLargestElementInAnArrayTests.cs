using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/kth-largest-element-in-an-array/
    public class L215KthLargestElementInAnArrayTests
    {
        private L215KthLargestElementInAnArray _l215KthLargestElementInAnArray;

        [Test]
        public void find_2th_largest_element_in_the_array()
        {
            _l215KthLargestElementInAnArray = new L215KthLargestElementInAnArray();
            ThekthItemShouldBe(5, new[] {3, 2, 1, 5, 6, 4}, 2);
        }

        [Test]
        public void find_4th_largest_element_in_the_array()
        {
            _l215KthLargestElementInAnArray = new L215KthLargestElementInAnArray();
            ThekthItemShouldBe(4, new[] {3, 2, 3, 1, 2, 4, 5, 5, 6}, 4);
        }

        private void ThekthItemShouldBe(int expected, int[] nums, int k)
        {
            Assert.AreEqual(expected, _l215KthLargestElementInAnArray.FindKthLargest(nums, k));
        }
    }
}
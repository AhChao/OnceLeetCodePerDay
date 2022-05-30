using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    public class L83RemoveDuplicatesFromSortedListTests
    {
        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            var l83RemoveDuplicatesFromSortedList = new L83RemoveDuplicatesFromSortedList();
            var head = new ListNode(1,new ListNode(2,new ListNode(2)));
            var expected = new ListNode(1, new ListNode(2));
            l83RemoveDuplicatesFromSortedList.DeleteDuplicates(head).Should().BeEquivalentTo(expected);
        }
    }
}
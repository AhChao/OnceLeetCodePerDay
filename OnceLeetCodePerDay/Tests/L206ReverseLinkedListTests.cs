using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/reverse-linked-list/
    public class L206ReverseLinkedListTests
    {
        [SetUp]
        public void SetUp()
        {
            _l206ReverseLinkedList = new L206ReverseLinkedList();
        }

        private L206ReverseLinkedList _l206ReverseLinkedList;
        private ListNode _head;
        private ListNode _expected;

        [Test]
        public void Example1_List_Should_Be_Reversed()
        {
            _head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            _expected = new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1)))));
            CheckResult();
        }

        private void CheckResult()
        {
            _l206ReverseLinkedList.ReverseList(_head).Should().BeEquivalentTo(_expected);
        }
    }
}
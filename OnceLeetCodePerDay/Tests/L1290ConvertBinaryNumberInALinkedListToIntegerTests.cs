using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
    public class L1290ConvertBinaryNumberInALinkedListToIntegerTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1290ConvertBinaryNumberInALinkedListToInteger = new L1290ConvertBinaryNumberInALinkedListToInteger();
        }

        private L1290ConvertBinaryNumberInALinkedListToInteger _l1290ConvertBinaryNumberInALinkedListToInteger;
        private ListNode _head;

        [Test]
        public void Example1_Should_Return_5()
        {
            _head = new ListNode(1, new ListNode(0, new ListNode(1)));
            ResultShouldBe(5);
        }

        [Test]
        public void Example2_Should_Return_0()
        {
            _head = new ListNode(0);
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1290ConvertBinaryNumberInALinkedListToInteger.GetDecimalValue(_head));
        }
    }
}
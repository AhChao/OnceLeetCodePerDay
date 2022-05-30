using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/remove-element/
    public class L27RemoveElementTests
    {
        private L27RemoveElement _l27RemoveElement;
        private int[] _nums;
        private int _val;

        [Test]
        public void Example1_Should_Remove_All_3_In_The_Array()
        {
            _l27RemoveElement = new L27RemoveElement();
            _nums = new[] {3, 2, 2, 3};
            _val = 3;
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Remove_All_2_In_The_Array()
        {
            _l27RemoveElement = new L27RemoveElement();
            _nums = new[] {0, 1, 2, 2, 3, 0, 4, 2};
            _val = 2;
            ResultShouldBe(5);
        }

        [Test]
        public void Example3_Empty_Array_Should_Work_Normal()
        {
            _l27RemoveElement = new L27RemoveElement();
            _nums = new int[] { };
            _val = 1;
            ResultShouldBe(0);
        }

        [Test]
        public void Example4_Remove_To_Empty_Array_Should_Work_Normal()
        {
            _l27RemoveElement = new L27RemoveElement();
            _nums = new int[] {1};
            _val = 1;
            ResultShouldBe(0);
        }

        [Test]
        public void Example5_No_Correspond_Value_In_Array_Should_Work_Normal()
        {
            _l27RemoveElement = new L27RemoveElement();
            _nums = new int[] {2};
            _val = 3;
            ResultShouldBe(1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l27RemoveElement.RemoveElement(_nums, _val));
            _nums.Take(expected).Should()
                 .BeEquivalentTo(_nums.Where(x => x != _val).Take(expected));
        }
    }
}
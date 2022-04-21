using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/richest-customer-wealth/
    public class L1672RichestCustomerWealthTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1672RichestCustomerWealth = new L1672RichestCustomerWealth();
        }

        private L1672RichestCustomerWealth _l1672RichestCustomerWealth;
        private int[][] _accounts;

        [Test]
        public void Compare_123_321_Return_6()
        {
            _accounts = new int[][] {new[] {1, 2, 3}, new[] {3, 2, 1}};
            MaxWealthShouldBe(6);
        }

        [Test]
        public void Compare_15_73_35_Return_10()
        {
            _accounts = new int[][] {new[] {1, 5}, new[] {7, 3}, new[] {3, 5}};
            MaxWealthShouldBe(10);
        }

        [Test]
        public void Compare_287_713_195_Return_17()
        {
            _accounts = new int[][] {new[] {2, 8, 7}, new[] {7, 1, 3}, new[] {1, 9, 5}};
            MaxWealthShouldBe(17);
        }

        private void MaxWealthShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1672RichestCustomerWealth.MaximumWealth(_accounts));
        }
    }
}
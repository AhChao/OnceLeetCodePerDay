using System.Collections.Generic;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/count-items-matching-a-rule/
    public class L1773CountItemsMatchingARuleTests
    {
        private L1773CountItemsMatchingARule _l1773CountItemsMatchingARule;
        private List<IList<string>> _items;
        private string _ruleKey;
        private string _ruleValue;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l1773CountItemsMatchingARule = new L1773CountItemsMatchingARule();
            _items = new List<IList<string>>()
                     {
                         new List<string>() {"phone", "blue", "pixel"},
                         new List<string>() {"computer", "silver", "lenovo"},
                         new List<string>() {"phone", "gold", "iphone"}
                     };
            _ruleKey = "color";
            _ruleValue = "silver";
            ResultShouldBe(1);
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l1773CountItemsMatchingARule = new L1773CountItemsMatchingARule();
            _items = new List<IList<string>>()
                     {
                         new List<string>() {"phone", "blue", "pixel"},
                         new List<string>() {"computer", "silver", "lenovo"},
                         new List<string>() {"phone", "gold", "iphone"}
                     };
            _ruleKey = "type";
            _ruleValue = "phone";
            ResultShouldBe(2);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1773CountItemsMatchingARule.CountMatches(_items, _ruleKey, _ruleValue));
        }
    }
}
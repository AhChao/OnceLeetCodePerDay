using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/search-suggestions-system/
    public class L1268SearchSuggestionsSystemTests
    {
        private L1268SearchSuggestionsSystem _l1268SearchSuggestionsSystem;
        private string[] _products;
        private string _searchWord;
        private List<List<string>> _expected;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _l1268SearchSuggestionsSystem = new L1268SearchSuggestionsSystem();
            _products = new[] {"mobile", "mouse", "moneypot", "monitor", "mousepad"};
            _searchWord = "mouse";
            _expected = new List<List<string>>()
                        {
                            new List<string>() {"mobile", "moneypot", "monitor"},
                            new List<string>() {"mobile", "moneypot", "monitor"},
                            new List<string>() {"mouse", "mousepad"},
                            new List<string>() {"mouse", "mousepad"},
                            new List<string>() {"mouse", "mousepad"}
                        };
            CheckTheResult();
        }

        [Test]
        public void Example22Should_Work_As_Expected()
        {
            _l1268SearchSuggestionsSystem = new L1268SearchSuggestionsSystem();
            _products = new[] {"havana"};
            _searchWord = "havana";
            _expected = new List<List<string>>()
                        {
                            new List<string>() {"havana"},
                            new List<string>() {"havana"},
                            new List<string>() {"havana"},
                            new List<string>() {"havana"},
                            new List<string>() {"havana"},
                            new List<string>() {"havana"},
                        };
            CheckTheResult();
        }

        private void CheckTheResult()
        {
            _l1268SearchSuggestionsSystem.SuggestedProducts(_products, _searchWord).Should().BeEquivalentTo(_expected);
        }
    }
}
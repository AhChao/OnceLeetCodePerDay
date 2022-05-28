using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/backspace-string-compare/
    public class L844BackspaceStringCompareTests
    {
        private L844BackspaceStringCompare _l844BackspaceStringCompare;
        private string _s;
        private string _t;

        [Test]
        public void Example1_Should_Be_True()
        {
            _l844BackspaceStringCompare = new L844BackspaceStringCompare();
            _s = "ab#c";
            _t = "ad#c";
            ResultShouldBe(true);
        }

        [Test]
        public void Example2_Should_Be_True()
        {
            _l844BackspaceStringCompare = new L844BackspaceStringCompare();
            _s = "ab##";
            _t = "c#d#";
            ResultShouldBe(true);
        }

        [Test]
        public void Example3_Should_Be_False()
        {
            _l844BackspaceStringCompare = new L844BackspaceStringCompare();
            _s = "a#c";
            _t = "b";
            ResultShouldBe(false);
        }

        [Test]
        public void Example4_Should_Be_True()
        {
            _l844BackspaceStringCompare = new L844BackspaceStringCompare();
            _s = "a##c";
            _t = "#a#c";
            ResultShouldBe(true);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l844BackspaceStringCompare.BackspaceCompare(_s, _t));
        }
    }
}
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/flatten-nested-list-iterator/
    public class L341FlattenNestedListIteratorTests
    {
        private List<NestedInteger> _nestedInteger;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _nestedInteger = new List<NestedInteger>()
                             {
                                 new NestedInteger(new List<NestedInteger>()
                                                   {
                                                       new NestedInteger(1),
                                                       new NestedInteger(1)
                                                   }),
                                 new NestedInteger(2),
                                 new NestedInteger(new List<NestedInteger>()
                                                   {
                                                       new NestedInteger(1),
                                                       new NestedInteger(1)
                                                   })
                             };
            ResultShouldBe(new List<int>() {1, 1, 2, 1, 1});
        }

        [Test]
        public void Example2_Should_Work_As_Expected()
        {
            _nestedInteger = new List<NestedInteger>()
                             {
                                 new NestedInteger(1),
                                 new NestedInteger(new List<NestedInteger>()
                                                   {
                                                       new NestedInteger(4),
                                                       new NestedInteger(new List<NestedInteger>()
                                                                         {new NestedInteger(6)})
                                                   })
                             };
            ResultShouldBe(new List<int>() {1, 4, 6});
        }

        private void ResultShouldBe(List<int> expected)
        {
            var result = new List<int>();
            NestedIterator i = new NestedIterator(_nestedInteger);
            while(i.HasNext()) result.Add(i.Next());
            result.Should().Equal(expected);
        }
    }
}
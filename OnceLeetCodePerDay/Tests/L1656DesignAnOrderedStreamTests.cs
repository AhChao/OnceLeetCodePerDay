using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/design-an-ordered-stream/
    public class L1656DesignAnOrderedStreamTests
    {
        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            var orderedStream = new OrderedStream(5);
            orderedStream.Insert(3, "ccccc").Should().BeEquivalentTo(new string[] { });
            orderedStream.Insert(1, "aaaaa").Should().BeEquivalentTo(new string[] {"aaaaa"});
            orderedStream.Insert(2, "bbbbb").Should().BeEquivalentTo(new string[] {"bbbbb", "ccccc"});
            orderedStream.Insert(5, "eeeee").Should().BeEquivalentTo(new string[] { });
            orderedStream.Insert(4, "ddddd").Should().BeEquivalentTo(new string[] {"ddddd", "eeeee"});
        }
    }
}
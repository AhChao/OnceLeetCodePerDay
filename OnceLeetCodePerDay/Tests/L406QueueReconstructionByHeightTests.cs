using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/queue-reconstruction-by-height/
    public class L406QueueReconstructionByHeightTests
    {
        [Test]
        public void Test1()
        {
            var l406QueueReconstructionByHeight = new L406QueueReconstructionByHeight();
            var people = new[] {new[] {7, 0}, new[] {4, 4}, new[] {7, 1}, new[] {5, 0}, new[] {6, 1}, new[] {5, 2},};
            var expected = new[] {new[] {5, 0}, new[] {7, 0}, new[] {5, 2}, new[] {6, 1}, new[] {4, 4}, new[] {7, 1},};
            l406QueueReconstructionByHeight.ReconstructQueue(people).Should()
                                           .BeEquivalentTo(expected, rules => rules.WithStrictOrdering());
        }
    }
}
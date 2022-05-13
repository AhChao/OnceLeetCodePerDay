using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/
    public class L117PopulatingNextRightPointersInEachNodeIITests
    {
        [SetUp]
        public void SetUp()
        {
            _l117PopulatingNextRightPointersInEachNodeIi = new L117PopulatingNextRightPointersInEachNodeII();
        }

        private L117PopulatingNextRightPointersInEachNodeII _l117PopulatingNextRightPointersInEachNodeIi;
        private Node _root;

        [Test]
        public void Example1_Should_Return_AS_Expected()
        {
            _root = new Node(1, new Node(2, new Node(4), new Node(5), null), new Node(3, null, new Node(7), null),
                             null);
            var clone = JsonConvert.DeserializeObject<Node>(JsonConvert.SerializeObject(_root));
            var expected = clone;
            clone.left.next = clone.right;
            clone = clone.left;
            clone.left.next = clone.right;
            clone.right.next = expected.right.right;
            ResultShouldBe(expected);
        }

        [Test]
        public void Example2_Should_Return_AS_Expected()
        {
            _root = null;
            ResultShouldBe(null);
        }

        private void ResultShouldBe(Node expected)
        {
            _l117PopulatingNextRightPointersInEachNodeIi.Connect(_root).Should().BeEquivalentTo(expected);
        }
    }
}
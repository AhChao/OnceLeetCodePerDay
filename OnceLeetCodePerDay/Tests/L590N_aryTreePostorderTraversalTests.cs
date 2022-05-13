using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/n-ary-tree-postorder-traversal/
    public class L590N_aryTreePostorderTraversalTests
    {
        [SetUp]
        public void SetUp()
        {
            _l590NAryTreePostorderTraversal = new L590N_aryTreePostorderTraversal();
        }

        private L590N_aryTreePostorderTraversal _l590NAryTreePostorderTraversal;
        private Node590 _root;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _root = new Node590(1,
                                new List<Node590>()
                                {
                                    new Node590(3, new List<Node590>() {new Node590(5), new Node590(6)}),
                                    new Node590(2),
                                    new Node590(4)
                                }
                               );
            ResultShouldBe(new List<int>() {5, 6, 3, 2, 4, 1});
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _root = null;
            ResultShouldBe(new List<int>());
        }

        private void ResultShouldBe(List<int> expectation)
        {
            _l590NAryTreePostorderTraversal.Postorder(_root).Should().BeEquivalentTo(
             expectation);
        }
    }
}
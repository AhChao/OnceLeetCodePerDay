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
        private NArrayTreeNode _root;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _root = new NArrayTreeNode(1,
                                new List<NArrayTreeNode>()
                                {
                                    new NArrayTreeNode(3, new List<NArrayTreeNode>() {new NArrayTreeNode(5), new NArrayTreeNode(6)}),
                                    new NArrayTreeNode(2),
                                    new NArrayTreeNode(4)
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
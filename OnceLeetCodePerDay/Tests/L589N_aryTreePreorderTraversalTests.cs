using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/n-ary-tree-preorder-traversal/
    public class L589N_aryTreePreorderTraversalTests
    {
        [SetUp]
        public void SetUp()
        {
            _l589NAryTreePreorderTraversal = new L589N_aryTreePreorderTraversal();
        }

        private L589N_aryTreePreorderTraversal _l589NAryTreePreorderTraversal;
        private NArrayTreeNode _root;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _root = new NArrayTreeNode(1, new List<NArrayTreeNode>()
                                          {
                                              new(3, new List<NArrayTreeNode>() {new(5), new(6)}),
                                              new(2),
                                              new(4)
                                          });
            ResultShouldBe(new[] {1, 3, 5, 6, 2, 4});
        }

        private void ResultShouldBe(int[] expectation)
        {
            _l589NAryTreePreorderTraversal.Preorder(_root).Should()
                                          .BeEquivalentTo(expectation,
                                                          options => options.WithStrictOrdering());
        }
    }
}
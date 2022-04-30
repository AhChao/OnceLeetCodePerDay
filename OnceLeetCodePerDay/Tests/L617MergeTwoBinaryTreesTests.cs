using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/merge-two-binary-trees/
    public class L617MergeTwoBinaryTreesTests
    {
        [SetUp]
        public void SetUp()
        {
            _l617MergeTwoBinaryTrees = new L617MergeTwoBinaryTrees();
        }

        private L617MergeTwoBinaryTrees _l617MergeTwoBinaryTrees;
        private TreeNode _root1;
        private TreeNode _root2;

        [Test]
        public void Example1_Merge_Result_Should_Be_Same_To_Expected()
        {
            _root1 = new TreeNode(1, new TreeNode(3, new TreeNode(5), null), new TreeNode(2));
            _root2 = new TreeNode(2, new TreeNode(1, null, new TreeNode(4)), new TreeNode(3, null, new TreeNode(7)));
            MergeResultShouldBe(new TreeNode(3, new TreeNode(4, new TreeNode(5), new TreeNode(4)),
                                             new TreeNode(5, null, new TreeNode(7))));
        }

        [Test]
        public void Example2_Merge_Result_Should_Be_Same_To_Expected()
        {
            _root1 = new TreeNode(1);
            _root2 = new TreeNode(1, new TreeNode(2));
            MergeResultShouldBe(new TreeNode(2, new TreeNode(2)));
        }

        private void MergeResultShouldBe(TreeNode expected)
        {
            _l617MergeTwoBinaryTrees.MergeTrees(_root1, _root2).Should().BeEquivalentTo(expected);
        }
    }
}
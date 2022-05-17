using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/
    public class L1379FindACorrespondingNodeOfABinaryTreeInACloneOfThatTreeTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1379FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree =
                new L1379FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree();
        }

        private L1379FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
            _l1379FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree;

        private TreeNode _original;
        private TreeNode _cloned;

        [Test]
        public void Example1_Should_Be_As_Expected()
        {
            _original = new TreeNode(7, new TreeNode(4), new TreeNode(3, new TreeNode(6), new TreeNode(19)));
            _cloned = new TreeNode(7, new TreeNode(4), new TreeNode(3, new TreeNode(6), new TreeNode(19)));
            ResultShouldBe(_original.right, _cloned.right);
        }

        [Test]
        public void Example2_Should_Be_As_Expected()
        {
            _original = new TreeNode(7);
            _cloned = new TreeNode(7);
            ResultShouldBe(_original, _cloned);
        }

        [Test]
        public void Example3_Should_Be_As_Expected()
        {
            _original = new TreeNode(8, null,
                                     new TreeNode(6, null,
                                                  new TreeNode(5, null,
                                                               new TreeNode(4, null,
                                                                            new TreeNode(3, null,
                                                                                new TreeNode(2, null,
                                                                                    new TreeNode(1)))))));
            _cloned = new TreeNode(8, null,
                                   new TreeNode(6, null,
                                                new TreeNode(5, null,
                                                             new TreeNode(4, null,
                                                                          new TreeNode(3, null,
                                                                              new TreeNode(2, null,
                                                                                  new TreeNode(1)))))));
            ResultShouldBe(_original.right.right.right, _cloned.right.right.right);
        }

        private void ResultShouldBe(TreeNode target, TreeNode expected)
        {
            Assert.AreEqual(expected,
                            _l1379FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree.GetTargetCopy(_original,
                                _cloned,
                                target));
        }
    }
}
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/implement-stack-using-queues/
    public class L225ImplementStackUsingQueuesTests
    {
        [SetUp]
        public void SetUp()
        {
            _myStack = new MyStack();
        }

        private string[] _operations;
        private int[][] _ints;
        private MyStack _myStack;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _operations = new[] {"MyStack", "Push", "Push", "Top", "Pop", "Empty"};
            _ints = new[] {new int[] { }, new[] {1}, new[] {2}, new int[] { }, new int[] { }, new int[] { }};
            Assert.IsTrue(VerifyResult(new[] {null, null, null, 2.ToString(), 2.ToString(), false.ToString()}));
        }

        private bool VerifyResult(string?[] expected)
        {
            _myStack = new MyStack();
            for(var i = 1; i < _operations.Length; i++)
            {
                var obj = _ints[i].Length > 0 ? new object[] {_ints[i][0]} : null;
                var method = obj != null
                                 ? _myStack.GetType().GetMethod(_operations[i], new[] {typeof(int)})
                                 : _myStack.GetType().GetMethod(_operations[i]);
                var invokeResult = method.Invoke(_myStack, obj)?.ToString();
                if(expected[i] != invokeResult)
                    return false;
            }

            return true;
        }
    }
}
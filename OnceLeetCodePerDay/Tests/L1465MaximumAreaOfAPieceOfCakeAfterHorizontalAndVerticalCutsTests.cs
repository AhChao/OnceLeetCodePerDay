using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/maximum-area-of-a-piece-of-cake-after-horizontal-and-vertical-cuts/
    public class L1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCutsTests
    {
        private L1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts
            _l1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts;

        private int _h;
        private int _w;
        private int[] _horizontalCuts;
        private int[] _verticalCuts;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _l1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts =
                new L1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts();
            _h = 5;
            _w = 4;
            _horizontalCuts = new[] {1, 2, 4};
            _verticalCuts = new[] {1, 3};
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Work_As_Expected()
        {
            _l1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts =
                new L1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts();
            _h = 5;
            _w = 4;
            _horizontalCuts = new[] {3, 1};
            _verticalCuts = new[] {1};
            ResultShouldBe(6);
        }

        [Test]
        public void Example3_Should_Work_As_Expected()
        {
            _l1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts =
                new L1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts();
            _h = 5;
            _w = 4;
            _horizontalCuts = new[] {3};
            _verticalCuts = new[] {3};
            ResultShouldBe(9);
        }

        [Test]
        public void Example4_Should_Work_As_Expected()
        {
            _l1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts =
                new L1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts();
            _h = 1000000000;
            _w = 1000000000;
            _horizontalCuts = new[] {2};
            _verticalCuts = new[] {2};
            ResultShouldBe(81);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected,
                            _l1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts.MaxArea(_h, _w,
                                _horizontalCuts,
                                _verticalCuts));
        }
    }
}
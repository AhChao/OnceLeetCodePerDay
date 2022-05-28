using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/critical-connections-in-a-network/
    public class L1192CriticalConnectionsInANetworkTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1192CriticalConnectionsInANetwork = new L1192CriticalConnectionsInANetwork();
        }

        private L1192CriticalConnectionsInANetwork _l1192CriticalConnectionsInANetwork;
        private int _n;
        private List<IList<int>> _connections;
        private List<List<int>> _expected;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _n = 4;
            _connections = new List<IList<int>>()
                           {
                               new List<int>() {0, 1},
                               new List<int>() {1, 2},
                               new List<int>() {2, 0},
                               new List<int>() {1, 3}
                           };
            _expected = new List<List<int>>() {new() {1, 3}};
            CheckResult();
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _n = 2;
            _connections = new List<IList<int>>()
                           {
                               new List<int>() {0, 1}
                           };
            _expected = new List<List<int>>() {new() {0, 1}};
            CheckResult();
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _n = 6;
            _connections = new List<IList<int>>()
                           {
                               new List<int>() {0, 1},
                               new List<int>() {1, 2},
                               new List<int>() {2, 0},
                               new List<int>() {1, 3},
                               new List<int>() {3, 4},
                               new List<int>() {4, 5},
                               new List<int>() {5, 3},
                           };
            _expected = new List<List<int>>() {new() {1, 3}};
            CheckResult();
        }

        [Test]
        public void Example4_Should_Return_As_Expected()
        {
            _n = 5;
            _connections = new List<IList<int>>()
                           {
                               new List<int>() {1, 0},
                               new List<int>() {2, 0},
                               new List<int>() {3, 2},
                               new List<int>() {4, 2},
                               new List<int>() {3, 0},
                               new List<int>() {4, 0},
                           };
            _expected = new List<List<int>>() {new() {0, 1}};
            CheckResult();
        }
        private void CheckResult()
        {
            _l1192CriticalConnectionsInANetwork.CriticalConnections(_n, _connections).Should()
                                               .BeEquivalentTo(_expected);
        }
    }
}
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/n-queens-ii/
    public class L52NQueensIITests
    {
        [Test]
        public void Input_4_Queens_Can_Get_Max_2_Ways()
        {
            var l52NQueensIi = new L52NQueensII();
            Assert.AreEqual(2,l52NQueensIi.TotalNQueens(4));
        }
    }
}
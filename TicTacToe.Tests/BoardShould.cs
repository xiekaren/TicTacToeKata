using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class BoardShould
    {
        [Test]
        public void GetDiagonals()
        {
            var board = new Board("X X" +
                                  " O " +
                                  "X X");
            var expected = new List<string> {"XOX", "XOX"};
            Assert.AreEqual(expected, board.GetDiagonals());
        }
        
        [Test]
        public void GetRows()
        {
            var board = new Board("XXX" +
                                  "OOO" +
                                  "XXX");
            var expected = new List<string> {"XXX", "OOO", "XXX"};
            Assert.AreEqual(expected, board.GetRows());
        }

        [Test]
        public void GetColumns()
        {
            var board = new Board("X O" +
                                  "X O" +
                                  "X O");
            var expected = new List<string> { "XXX", "   ", "OOO" };
            Assert.AreEqual(expected, board.GetColumns());
        }

    }
}

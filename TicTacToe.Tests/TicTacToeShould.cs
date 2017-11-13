using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeShould
    {
        private TicTacToe _ticTacToe;

        [SetUp]
        public void SetUp()
        {
            _ticTacToe = new TicTacToe();;
        }

        [Test]
        public void ReturnFindFirstEmptyPositionToPlay()
        {
            Assert.AreEqual(3, _ticTacToe.Solve("XOX   XO "));
        }

        [Test]
        [TestCase("XX ", "X")]
        [TestCase("X X", "X")]
        public void ReturnTrueWhenPlayerCanWin(string line, string playerToken)
        {
            Assert.IsTrue(_ticTacToe.CanWin(line, playerToken));
        }

        [Test]
        [TestCase("X 0", "X")]
        [TestCase("XX0", "X")]
        public void ReturnFalseWhenPlayerCannotWin(string line, string playerToken)
        {
            Assert.IsFalse(_ticTacToe.CanWin(line, playerToken));
        }

        [Test]
        public void GetRows()
        {
            CollectionAssert.AreEqual(new List<string> {"XXX", "OOO", "XXX"}, _ticTacToe.GetRows("XXXOOOXXX", 3, 3));
        }

    }
}

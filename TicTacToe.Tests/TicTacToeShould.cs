using System;
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
        public void AddTokenToBoardAtPosition()
        {
            Assert.AreEqual("XOXXOXXOX", _ticTacToe.MakePlay("XOXXOXXO ", "X", 8));
        }

        [Test]
        [TestCase("X        ", 0)]
        [TestCase("X        ", -1)]
        [TestCase("X        ", 9)]
        public void CheckForInvalidPlays(string board, int position)
        {
            Assert.Throws<ArgumentException>(() => _ticTacToe.IsValidPlay(board, position));
        }
    }
}

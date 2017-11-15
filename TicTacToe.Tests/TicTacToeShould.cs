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
        public void ReturnFirstEmptyPositionToPlay()
        {
            Assert.AreEqual(3, _ticTacToe.Solve("XOX   XO "));
        }

        [Test]
        public void AddTokenToBoardAtPosition()
        {
            Assert.AreEqual("XOXXOXXOX", _ticTacToe.MakePlay("XOXXOXXO ", "X", 8));
        }
    }
}

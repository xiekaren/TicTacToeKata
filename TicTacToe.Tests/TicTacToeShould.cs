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
    }
}

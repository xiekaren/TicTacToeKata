using System;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class InputCheckerShould
    {
        [Test]
        [TestCase("-1", "Please enter a position from 1 to 9.")]
        [TestCase("10", "Please enter a position from 1 to 9.")]
        [TestCase("5", "Please enter an unoccupied position from 1 to 9.")]
        public void GiveErrorMessageForInvalidPlaysForBoard(string input, string expectedMessage)
        {
            var inputChecker = new InputChecker();
            var board = new Board(new []
            {
                "-", "-", "-",
                "-", "O", "-",
                "-", "-", "-"
            });

            Assert.That(() => inputChecker.Validate(board, input),
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo(expectedMessage));
        }
    }
}

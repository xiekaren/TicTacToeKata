using System;
using NUnit.Framework;
using TicTacToe.Checker;
using TicTacToe.GameElements;

namespace TicTacToe.Tests.Checker
{
    [TestFixture]
    public class InputCheckerShould
    {
        [Test]
        [TestCase("-1", "Please enter a position from 1 to 9.")]
        [TestCase("10", "Please enter a position from 1 to 9.")]
        [TestCase("5", "Please enter an unoccupied position from 1 to 9.")]
        public void ValidateInput(string input, string expectedMessage)
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

using System;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    public class InputValidatorShould
    {
        [Test]
        [TestCase("choose a position on the board", "---" +
                                                    "---" +
                                                    "---", "9")]
        [TestCase("choose a position on the board", "---" +
                                                    "---" +
                                                    "---", "-1")]
        [TestCase("choose an empty position", "X--" +
                                              "---" +
                                              "---", "0")]
        [TestCase("choose a number between 0 and 8", "X--" +
                                                     "---" +
                                                     "---", "*")]
        public void ValidateInput(string expectedMessage, string inputBoard, string position)
        {
            var board = new Board(inputBoard);
            var inputValidator = new InputValidator();

            Assert.That(() => inputValidator.ValidateMove(board, position),
                Throws.TypeOf<ArgumentException>().With.Message.Contains(expectedMessage));
        }
    }
}

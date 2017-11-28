using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeShould
    {
        [Test]
        public void FormatBoard()
        {
            var input = new[]
            {
                "-", "-", "-",
                "-", "-", "-",
                "-", "-", "-"
            };

            const string expectedBoard = " - | - | - " +
                                         "\n-----------\n" +
                                         " - | - | - " +
                                         "\n-----------\n" +
                                         " - | - | - ";

            var board = new Board(input);
            var game = new TicTacToe();

            var actualBoard = game.FormatBoard(board);
            Assert.AreEqual(expectedBoard, actualBoard);
        }
    }
}

using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class DisplayShould
    {
        [Test]
        [TestCase(new[]
        {
            "-", "-", "-",
            "-", "-", "-",
            "-", "-", "-"
        },
            "\n - | - | - " +
            "\n-----------\n" +
            " - | - | - " +
            "\n-----------\n" +
            " - | - | - \n"
        )]
        [TestCase(new[]
            {
                "-", "-", "-",
                "X", "O", "-",
                "-", "-", "X"
            },
            "\n - | - | - " +
            "\n-----------\n" +
            " X | O | - " +
            "\n-----------\n" +
            " - | - | X \n"
        )]
        public void FormatBoard(string[] input, string expectedBoard)
        {
            var board = new Board(input);
            var display = new Display();

            var actualBoard = display.RenderBoard(board);

            Assert.AreEqual(expectedBoard, actualBoard);
        }

        [TestCase("", "Draw!")]
        [TestCase(null, "Draw!")]
        [TestCase("X", "Player X wins!")]
        [TestCase("O", "Player O wins!")]
        [TestCase("E", "")]
        public void PrintMessageBasedOnWinner(string winner, string expectedMessage)
        {
            var display = new Display();;
            var actualMessage = display.RenderWin(winner);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}

using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class RendererShould
    {
        [Test]
        [TestCase(new[]
        {
            "O", "-", "-",
            "-", "X", "-",
            "-", "-", "O"
        },
            " O | - | - \n" +
            "-----------\n" +
            " - | X | - \n" +
            "-----------\n" +
            " - | - | O ")]
        public void DisplayBoardInGridFormat(string[] input, string expectedGrid)
        {
            var game = new Renderer();
            var actualGrid = game.FormatBoardAsGrid(new Board(input));
            Assert.AreEqual(expectedGrid, actualGrid);
        }

        [Test]
        [TestCase("", "Draw!")]
        [TestCase("O", "You win!")]
        [TestCase("X", "Computer wins!")]
        public void FormatWinnerMessage(string winner, string expectedMessage)
        {
            var game = new Renderer();
            var actualMessage = game.FormatWinnerMessage(winner);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}

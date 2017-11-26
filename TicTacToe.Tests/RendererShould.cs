using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class RendererShould
    {
        [Test]
        [TestCase(new[]
        {
            "-", "-", "-",
            "-", "-", "-",
            "-", "-", "-"
        },
            " - | - | - \n" +
            "-----------\n" +
            " - | - | - \n" +
            "-----------\n" +
            " - | - | - ")]
        public void DisplayBoardInGridFormat(string[] input, string expectedGrid)
        {
            var game = new Renderer();
            var actualGrid = game.FormatBoardAsGrid(new Board(input));
            Assert.AreEqual(expectedGrid, actualGrid);
        }
    }
}

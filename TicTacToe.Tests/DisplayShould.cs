using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class DisplayShould
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
            var display = new Display();

            var actualBoard = display.RenderBoard(board);

            Assert.AreEqual(expectedBoard, actualBoard);
        }

    }
}

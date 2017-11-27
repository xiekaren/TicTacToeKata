using NUnit.Framework;
using TicTacToe.Checker;
using TicTacToe.GameElements;

namespace TicTacToe.Tests.Checker
{
    [TestFixture]
    public class WinCheckerShould
    {
        [Test]
        [TestCase(new[]
        {
            "X", "X", "O",
            "O", "O", "X",
            "-", "O", "X"
        }, "")]
        [TestCase(new[]
        {
            "X", "X", "O",
            "O", "O", "X",
            "O", "O", "X"
        }, "O")]
        [TestCase(new[]
        {
            "X", "X", "X",
            "O", "X", "O",
            "O", "O", "X"
        }, "X")]
        [TestCase(new[]
        {
            "X", "X", "O",
            "O", "X", "X",
            "O", "X", "O"
        }, "X")]
        public void CheckForWinner(string[] inputBoard, string expectedWinner)
        {
            var board = new Board(inputBoard);
            var winChecker = new WinChecker();
            Assert.AreEqual(expectedWinner, winChecker.GetWinner(board));
        }
    }
}
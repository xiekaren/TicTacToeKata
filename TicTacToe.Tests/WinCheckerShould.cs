using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class WinCheckerShould
    {
        [TestCase(new[]
        {
            "O", "X", "-",
            "-", "O", "X",
            "-", "-", "O"
        }, "O")]
        [TestCase(new[]
        {
            "O", "X", "X",
            "-", "-", "X",
            "X", "-", "O"
        }, "")]
        [TestCase(new[]
        {
            "X", "O", "X",
            "X", "O", "O",
            "X", "-", "O"
        }, "X")]
        [TestCase(new[]
        {
            "X", "X", "X",
            "-", "O", "O",
            "O", "-", "O"
        }, "X")]
        public void GetWinner(string[] input, string expectedWinner)
        {
            var board = new Board(input);
            var winChecker = new WinChecker();
            Assert.AreEqual(expectedWinner, winChecker.GetWinner(board));
        }
    }
}

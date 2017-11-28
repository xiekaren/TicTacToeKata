using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class WinCheckerShould
    {
        [Test]
        public void GetWinner()
        {
            var board = new Board(new[]
            {
                "O", "X", "-",
                "-", "O", "X",
                "-", "-", "O"
            });

            var winChecker = new WinChecker();
            Assert.AreEqual("O", winChecker.GetWinner(board));
        }
    }
}

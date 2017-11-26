using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class WinCheckerShould
    {
        [Test]
        public void CheckForWinner()
        {
            var board = new Board(new []
            {
                "-", "-","-",
                "O", "O","O",
                "-", "-","-"
            });

            var winChecker = new WinChecker();

            Assert.AreEqual("O", winChecker.GetWinner(board));
        }
    }
}

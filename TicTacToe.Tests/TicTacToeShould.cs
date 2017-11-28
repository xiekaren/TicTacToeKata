using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeShould
    {
        [Test]
        public void ToggleBetweenXandO()
        {
            var board = new Board();
            var game = new TicTacToe(board, new GameState());
            Assert.AreEqual("X", game.CurrentPlayer);
            game.ToggleCurrentPlayer();
            Assert.AreEqual("O", game.CurrentPlayer);
        }
    }
}

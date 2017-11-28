using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class GameStateShould
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

            var gameState = new GameState("X");
            Assert.AreEqual("O", gameState.Winner(board));
        }

        [Test]
        [TestCase(new[]
        {
            "-", "-", "-",
            "-", "-", "-",
            "-", "-", "-"
        }, false)]
        [TestCase(new[]
        {
            "X", "X", "X",
            "O", "O", "-",
            "O", "-", "-"
        }, true)]
        public void CheckIfGameEnded(string[] inputSquares, bool expectedResult)
        {
            var board = new Board(inputSquares);
            var gameState = new GameState("X");
            Assert.AreEqual(expectedResult, gameState.HasEnded(board));
        }

        [Test]
        public void ToggleCurrentPlayer()
        {
            var gameState = new GameState("X");
            Assert.AreEqual("X", gameState.CurrentPlayer);
            gameState.ToggleCurrentPlayer();
            Assert.AreEqual("O", gameState.CurrentPlayer);
        }
    }
}

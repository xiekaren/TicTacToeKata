using NUnit.Framework;
using TicTacToe.GameElements;
using TicTacToe.Player;

namespace TicTacToe.Tests.Player
{
    [TestFixture]
    public class ComputerPlayerShould
    {
        [Test]
        [TestCase("-,-,-," +
                  "-,-,-," +
                  "-,-,-,", 1)]
        [TestCase("X,-,-," +
                  "-,-,-," +
                  "-,-,-,", 2)]
        [TestCase("X,X,O," +
                  "O,-,X," +
                  "-,-,-,", 5)]
        public void SolveByTakingTheFirstFreePosition(string initialGrid, int expectedMove)
        {
            var board = new Board(initialGrid.Split(','));
            IPlayer player = new ComputerPlayer();

            var desiredMove = player.Solve(board);

            Assert.AreEqual(expectedMove, desiredMove);
        }
    }
}

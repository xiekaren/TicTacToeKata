using NUnit.Framework;

namespace TicTacToe.Tests
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
        [TestCase("X,X,-," +
                  "-,-,-," +
                  "-,-,-,", 3)]
        public void GetFirstFreePositionAsDesiredMove(string initialGrid, int expectedMove)
        {
            var board = new Board(initialGrid.Split(','));
            IPlayer player = new ComputerPlayer();

            var desiredMove = player.GetDesiredMove(board);

            Assert.AreEqual(expectedMove, desiredMove);
        }
    }
}

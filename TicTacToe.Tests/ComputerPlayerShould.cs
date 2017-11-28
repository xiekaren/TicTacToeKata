using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class ComputerPlayerShould
    {
        [Test]
        [TestCase(new[]
        {
            "-","-","-",
            "-","-","-",
            "-","-","-"
        }, 1)]
        [TestCase(new[]
        {
            "X","-","-",
            "-","-","-",
            "-","-","-"
        }, 2)]
        [TestCase(new[]
        {
            "-","-","-",
            "-","O","-",
            "-","-","-"
        }, 1)]
        public void SolveByTakingTheFirstPositionAvailable(string[] inputSquares, int expectedPosition)
        {
            var board = new Board(inputSquares);
            var player = new ComputerPlayer();
            Assert.AreEqual(expectedPosition, player.Solve(board));
        }
    }
}

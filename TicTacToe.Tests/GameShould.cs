using Moq;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class GameShould
    {
        private Mock<Prompt> _prompt;
        private Mock<Board> _board;

        [SetUp]
        public void SetUp()
        {
            _prompt = new Mock<Prompt>();
            _board = new Mock<Board>();
        }

        [Test]
        public void SolveByTakingTheFirstEmptyPosition()
        {
            var board = new Board("XO-" +
                                  "---" +
                                  "---");

            var game = new Game(_prompt.Object, board);
            var desiredMove = game.Solve(board);

            Assert.AreEqual(2, desiredMove);
        }
    }
}
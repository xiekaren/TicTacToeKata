using Moq;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeGameShould
    {
        private Mock<Renderer> _renderer;

        [SetUp]
        public void SetUp()
        {
            _renderer = new Mock<Renderer>();  
        }

        [Test]
        [TestCase("X", "XXX" +
                       "OOO" +
                       "OOX")]
        [TestCase("O", "OXX" +
                       "OX " +
                       "OO ")]
        [TestCase("",  "XXO" +
                       "OOX" +
                       "XOX")]
        public void PrintWinnerIfFound(string expected, string inputBoard)
        {
            _renderer.Setup(t => t.PrintWinner(expected));
            var board = new Board(inputBoard);
            var game = new TicTacToeGame(_renderer.Object, board);

            game.Start();

            _renderer.Verify(x => x.PrintWinner(expected), Times.Once);
        }

    }
}

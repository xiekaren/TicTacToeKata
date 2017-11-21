using Moq;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeGameShould
    {
        private Mock<Renderer> _renderer;
        private Mock<Board> _board;

        [SetUp]
        public void SetUp()
        {
            _renderer = new Mock<Renderer>();  
            _board = new Mock<Board>();
        }

        [Test]
        [TestCase("X", "XXX" +
                       "OOO" +
                       "OOX")]
        [TestCase("O", "OXX" +
                       "OX-" +
                       "OO-")]
        [TestCase("",  "XXO" +
                       "OOX" +
                       "XOX")]
        [TestCase("", "---" +
                      "---" +
                      "---")]
        public void PrintWinnerIfFound(string expected, string inputBoard)
        {
            _renderer.Setup(t => t.PrintWinner(expected));
            var board = new Board(inputBoard);

            var game = new TicTacToeGame(_renderer.Object, board);
            game.Start();

            _renderer.Verify(x => x.PrintWinner(expected), Times.Once);
        }

        [Test]
        public void EndGameWhenBoardIsFilled()
        {
            _board = new Mock<Board>();
            _board.Setup(x => x.IsFilled()).Returns(true);
            _board.Setup(x => x.GetWinner()).Returns("");
            _renderer.Setup(x => x.PrintGameEnded());

            var game = new TicTacToeGame(_renderer.Object, _board.Object);
            game.Start();

            _board.Verify(x => x.IsFilled(), Times.Once);
            _renderer.Verify(x => x.PrintGameEnded(), Times.Once);
        }

        [Test]
        public void NotEndGameWhenBoardIsNotFilled()
        {
            _board.Setup(x => x.IsFilled()).Returns(false);
            _board.Setup(x => x.GetWinner()).Returns("");
            _renderer.Setup(x => x.PrintGameEnded());

            var game = new TicTacToeGame(_renderer.Object, _board.Object);
            game.Start();

            _board.Verify(x => x.IsFilled(), Times.Once);
            _renderer.Verify(x => x.PrintGameEnded(), Times.Never);
        }

    }
}

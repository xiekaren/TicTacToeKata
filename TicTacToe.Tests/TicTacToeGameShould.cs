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
        public void PrintWinnerWhenTheBoardIsFilled()
        {
            _renderer.Setup(t => t.PrintWinner(It.IsAny<string>()));
            var board = new Board("XXO" +
                                  "OXO" +
                                  "OOX");
            var game = new TicTacToeGame(_renderer.Object, board);

            game.Start();

            _renderer.Verify(x => x.PrintWinner(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void NotPrintWinnerWhenTheBoardIsNotFilled()
        {
            _renderer.Setup(t => t.PrintWinner(It.IsAny<string>()));
            var board = new Board("XXO" +
                                  "OXO" +
                                  "OO ");
            var game = new TicTacToeGame(_renderer.Object, board);

            game.Start();

            _renderer.Verify(x => x.PrintWinner(It.IsAny<string>()), Times.Never);
        }

        [Test]
        //TODO: Inprogress
        public void PrintGetAndPrintWinnerWhenBoardIsFilled()
        {
            _renderer.Setup(t => t.PrintWinner("O"));
            var board = new Board("XXX" +
                                  "XOO" +
                                  "OOX");
            var game = new TicTacToeGame(_renderer.Object, board);

            game.Start();

            _renderer.Verify(x => x.PrintWinner("O"), Times.Once);
        }

    }
}

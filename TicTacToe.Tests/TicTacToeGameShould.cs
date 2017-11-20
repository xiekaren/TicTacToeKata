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
            _renderer.Setup(t => t.PrintWinner());
        }

        [Test]
        public void PrintWinnerWhenTheBoardIsFilled()
        {
            var board = new Board("XXO" +
                                  "OXO" +
                                  "OOX");
            var game = new TicTacToeGame(_renderer.Object, board);

            game.Start();

            _renderer.Verify(x => x.PrintWinner(), Times.Once);
        }

        [Test]
        public void NotPrintWinnerWhenTheBoardIsNotFilled()
        {
            var board = new Board("XXO" +
                                  "OXO" +
                                  "OO ");
            var game = new TicTacToeGame(_renderer.Object, board);

            game.Start();

            _renderer.Verify(x => x.PrintWinner(), Times.Never);
        }

    }
}

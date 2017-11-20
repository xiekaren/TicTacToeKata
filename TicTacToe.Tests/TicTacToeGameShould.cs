using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeGameShould
    {
        [Test]
        public void EndWhenTheBoardIsFilled()
        {
            var renderer = new Renderer();
            var board = new Board("OXX" +
                                  "OXX" +
                                  "XOO");
            var game = new TicTacToeGame(renderer, board);
            Assert.AreEqual("Helo", board);
        }
    }

    public class Board
    {
        private string _board;

        public Board(string input)
        {
            _board = input;
        }
    }

    public class TicTacToeGame
    {
        private Renderer _renderer;

        public TicTacToeGame(Renderer renderer, Board board)
        {
            _renderer = renderer;
        }
    }

    public class Renderer
    {
    }
}

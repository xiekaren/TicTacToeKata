using System;
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
        [TestCase("", "XXO" +
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

        [Test]
        public void UpdateBoardWithTokenAtPosition()
        {
            var board = new Board("---" +
                                  "---" +
                                  "---");
            var expectedBoard = new Board("X--" +
                                          "---" +
                                          "---");

            var game = new TicTacToeGame(_renderer.Object, board);
            var updatedBoard = game.MakePlay("X", 0);

            Assert.IsTrue(AreEqual(expectedBoard, updatedBoard));
        }

        private static bool AreEqual(Board board1, Board board2)
        {
            return board1.Get() == board2.Get();
        }

        [Test]
        [TestCase("choose a position on the board", "---" +
                                                    "---" +
                                                    "---", 9)]
        [TestCase("choose a position on the board", "---" +
                                                    "---" +
                                                    "---", -1)]
        [TestCase("choose an empty position", "X--" +
                                              "---" +
                                              "---", 0)]
        public void PrintErrorForInvalidInsertionIntoBoard(string expectedMessage, string inputBoard, int position)
        {
            var board = new Board(inputBoard);

            var game = new TicTacToeGame(_renderer.Object, board);

            Assert.That(() => game.MakePlay("X", position),
                Throws.TypeOf<ArgumentException>().With.Message.Contains(expectedMessage));
        }
    }
}
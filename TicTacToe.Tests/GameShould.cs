using System;
using Moq;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class GameShould
    {
        private Mock<UserInterface> _userInterface;
        private Mock<Board> _board;

        [SetUp]
        public void SetUp()
        {
            _userInterface = new Mock<UserInterface>();
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
            _userInterface.Setup(t => t.PrintWinner(expected));
            var board = new Board(inputBoard);

            var game = new Game(_userInterface.Object, board);
            game.Start();

            _userInterface.Verify(x => x.PrintWinner(expected), Times.Once);
        }

        [Test]
        public void EndGameWhenBoardIsFilled()
        {
            _board = new Mock<Board>();
            _board.Setup(x => x.IsFilled()).Returns(true);
            _board.Setup(x => x.GetWinner()).Returns("");
            _userInterface.Setup(x => x.PrintGameEnded());

            var game = new Game(_userInterface.Object, _board.Object);
            game.Start();

            _board.Verify(x => x.IsFilled(), Times.Once);
            _userInterface.Verify(x => x.PrintGameEnded(), Times.Once);
        }

        [Test]
        public void NotEndGameWhenBoardIsNotFilled()
        {
            _board.Setup(x => x.IsFilled()).Returns(false);
            _board.Setup(x => x.GetWinner()).Returns("");
            _userInterface.Setup(x => x.PrintGameEnded());

            var game = new Game(_userInterface.Object, _board.Object);
            game.Start();

            _board.Verify(x => x.IsFilled(), Times.Once);
            _userInterface.Verify(x => x.PrintGameEnded(), Times.Never);
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

            var game = new Game(_userInterface.Object, board);
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

            var game = new Game(_userInterface.Object, board);

            Assert.That(() => game.MakePlay("X", position),
                Throws.TypeOf<ArgumentException>().With.Message.Contains(expectedMessage));
        }

        [Test]
        public void SolveByTakingTheFirstEmptyPosition()
        {
            var board = new Board("XO-" +
                                  "---" +
                                  "---");

            var game = new Game(_userInterface.Object, board);
            var desiredMove = game.Solve(board);

            Assert.AreEqual(2, desiredMove);
        }

        [Test]
        public void ReadInput()
        {
            var board = new Mock<Board>();
            _userInterface.Setup(x => x.ReadInput()).Returns("1");
            _userInterface.Setup(x => x.PrintFormattedBoard(It.IsAny<Board>()));

            var game = new Game(_userInterface.Object, board.Object);
            game.Start();

            _userInterface.Verify(x => x.PrintFormattedBoard(It.IsAny<Board>()));
            _userInterface.Verify(x => x.ReadInput());
        }
    }
}
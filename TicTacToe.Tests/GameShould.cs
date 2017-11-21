﻿using System;
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
            _prompt.Setup(t => t.PrintWinner(expected));
            var board = new Board(inputBoard);

            var game = new Game(_prompt.Object, board);
            game.Start();

            _prompt.Verify(x => x.PrintWinner(expected), Times.Once);
        }

        [Test]
        public void EndGameWhenBoardIsFilled()
        {
            _board = new Mock<Board>();
            _board.Setup(x => x.IsFilled()).Returns(true);
            _board.Setup(x => x.GetWinner()).Returns("");
            _prompt.Setup(x => x.PrintGameEnded());

            var game = new Game(_prompt.Object, _board.Object);
            game.Start();

            _board.Verify(x => x.IsFilled(), Times.Once);
            _prompt.Verify(x => x.PrintGameEnded(), Times.Once);
        }

        [Test]
        public void NotEndGameWhenBoardIsNotFilled()
        {
            _board.Setup(x => x.IsFilled()).Returns(false);
            _board.Setup(x => x.GetWinner()).Returns("");
            _prompt.Setup(x => x.PrintGameEnded());

            var game = new Game(_prompt.Object, _board.Object);
            game.Start();

            _board.Verify(x => x.IsFilled(), Times.Once);
            _prompt.Verify(x => x.PrintGameEnded(), Times.Never);
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

            var game = new Game(_prompt.Object, board);
            var updatedBoard = game.MakePlay("X", 0);

            Assert.IsTrue(AreEqual(expectedBoard, updatedBoard));
        }

        private static bool AreEqual(Board board1, Board board2)
        {
            return board1.Grid == board2.Grid;
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
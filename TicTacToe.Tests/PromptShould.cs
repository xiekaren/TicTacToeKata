using System;
using System.IO;
using Moq;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class PromptShould
    {
        private Prompt _prompt;

        [SetUp]
        public void SetUp()
        {
            _prompt = new Prompt(new InputValidator());
        }

        [Test]
        public void FormatBoard()
        {
            var board = new Board("---" +
                                  "---" +
                                  "---");

            var formattedBoard = _prompt.FormatBoard(board);

            Assert.AreEqual("---\n---\n---\n", formattedBoard);
        }

        [Test]
        public void ReadValidPlayerMove()
        {
            var board = new Board("---" +
                                  "---" +
                                  "---");
            var playerMove = _prompt.ReadValidPlayerMove(board, "1");
            Assert.AreEqual(1, playerMove);
        }
    }
}

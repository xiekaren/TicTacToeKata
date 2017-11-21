using System;
using System.IO;
using Moq;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class UserInterfaceShould
    {
        private UserInterface _userInterface;

        [Test]
        public void FormatBoard()
        {
            var board = new Board("---" +
                                  "---" +
                                  "---");
            _userInterface = new UserInterface();

            var formattedBoard = _userInterface.FormatBoard(board);

            Assert.AreEqual("---\n---\n---\n", formattedBoard);
        }
    }
}

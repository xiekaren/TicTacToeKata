using Moq;
using NUnit.Framework;
using TicTacToe.Checker;
using TicTacToe.GameElements;
using TicTacToe.Player;

namespace TicTacToe.Tests.Player
{
    [TestFixture]
    public class HumanPlayerShould
    {
        public void SolveWithValidInput()
        {
            var mockConsole = new Mock<ConsoleWrapper>();
            mockConsole.Setup(t => t.ReadLine()).Returns("1");
            var player = new HumanPlayer(new InputChecker(), mockConsole.Object);

            var input = player.Solve(new Board());

            Assert.AreEqual(1, input);
        }
    }
}

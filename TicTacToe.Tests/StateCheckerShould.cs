using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class StateCheckerShould
    {
        private StateChecker _stateChecker;

        [SetUp]
        public void SetUp()
        {
            _stateChecker = new StateChecker();
        }

        [Test]
        [TestCase(true, "XOX" +
                        "OXO" +
                        "XOX")]
        [TestCase(false, "X X" +
                         "OOX" +
                         "OXO")]
        public void CheckForEndOfGame(bool expected, string board)
        {
            Assert.AreEqual(expected, _stateChecker.IsEndOfGame(board));
        }

        [Test]
        [TestCase("X", "XXX" +
                       "   " +
                       "   ")]
        [TestCase("",  "XOX" +
                       "XOX" +
                       "OXO")]
        [TestCase("O", "O X" +
                       "OXX" +
                       "O O")]
        public void CheckForWin(string expected, string input)
        {
            var board = new Board(input);
            Assert.AreEqual(expected, _stateChecker.CheckForWinner(board));
        }
    }
}

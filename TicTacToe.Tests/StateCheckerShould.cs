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
        [TestCase(true, "XXX")]
        [TestCase(false, "XOX")]
        public void CheckForWinInALine(bool expected, string line)
        {
            Assert.AreEqual(expected, _stateChecker.IsWin(line));
        }
    }
}

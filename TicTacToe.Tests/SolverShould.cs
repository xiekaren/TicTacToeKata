using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class SolverShould
    {
        private Solver _solver;

        [SetUp]
        public void SetUp()
        {
            _solver = new Solver();;
        }

        [Test]
        [TestCase("XX ", "X")]
        [TestCase("X X", "X")]
        public void ReturnTrueWhenPlayerCanWin(string line, string playerToken)
        {
            Assert.IsTrue(_solver.CanWin(line, playerToken));
        }

        [Test]
        [TestCase("X 0", "X")]
        [TestCase("XX0", "X")]
        public void ReturnFalseWhenPlayerCannotWin(string line, string playerToken)
        {
            Assert.IsFalse(_solver.CanWin(line, playerToken));
        }
    }
}

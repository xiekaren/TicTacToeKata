using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeShould
    {
        [Test]
        public void InitialiseEmpty3X3Grid()
        {
            var board = new Board(3, 3);
            Assert.AreEqual("", board.Get(0, 0));
            Assert.AreEqual("", board.Get(0, 1));
            Assert.AreEqual("", board.Get(0, 2));
            Assert.AreEqual("", board.Get(1, 0));
            Assert.AreEqual("", board.Get(1, 1));
            Assert.AreEqual("", board.Get(1, 2));
            Assert.AreEqual("", board.Get(2, 0));
            Assert.AreEqual("", board.Get(2, 1));
            Assert.AreEqual("", board.Get(2, 2));
        }

        [Test]
        public void SetValueAtPosition()
        {
            var board = new Board(3, 3);
            board.Set(0, 0, "x");
            Assert.AreEqual("x", board.Get(0, 0));
        }
    }
}

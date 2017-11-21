using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class RendererShould
    {
        private Renderer _renderer;

        [SetUp]
        public void SetUp()
        {
            _renderer = new Renderer();
        }

        [Test]
        public void FormatBoard()
        {
            var board = new Board("---" +
                                  "---" +
                                  "---");

            var formattedBoard = _renderer.FormatBoard(board);

            Assert.AreEqual("---\n---\n---\n", formattedBoard);
        }
    }
}

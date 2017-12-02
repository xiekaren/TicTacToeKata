using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeShould
    {
        [Test]
        public void DisplayBoard()
        {
            var input = new Board(3, 3);
            var expected = "[-][-][-]" +
                           "[-][-][-]" +
                           "[-][-][-]";
        }
    }

    public class Board
    {
        public Board(int width, int height)
        {
            throw new System.NotImplementedException();
        }
    }
}

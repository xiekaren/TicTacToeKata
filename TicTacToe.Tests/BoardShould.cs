using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class BoardShould
    {
        [Test]
        public void PlaceTokenAtPostition()
        {
            const int position = 2;
            const string token = "X";

            var board = new Board();
            board.PlaceTokenAtPosition(token, position);

            Assert.AreEqual(token, board.GetTokenAt(position));
        }
    }
}

using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class BoardShould
    {
        [Test]
        [TestCase(true,  "XXX" +
                         "XXX" +
                         "XXX")]
        [TestCase(false, "---" +
                         "---" +
                         "--X")]
        public void CheckIfFilled(bool expected, string inputBoard)
        {
            var board = new Board(inputBoard);
            Assert.AreEqual(expected, board.IsFilled());
        }

        [Test]
        [TestCase("X--" +
                  "---" +
                  "---", "X", 0)]
        public void PlaceTokenAtPosition(string expectedBoard, string token, int position)
        {
            var board = new Board("---" +
                                  "---" +
                                  "---");
            var actualBoard = board.PlaceToken(token, position);
            Assert.AreEqual(expectedBoard, actualBoard.Grid);
        }
    }
}

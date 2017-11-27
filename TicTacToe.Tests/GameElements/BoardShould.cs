using NUnit.Framework;
using TicTacToe.GameElements;

namespace TicTacToe.Tests.GameElements
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
            board.PlaceTokenAt(token, position);

            Assert.AreEqual(token, board.GetTokenAt(position));
        }

        [Test]
        public void GetTokenAtPosition()
        {
            const int position = 2;
            const string expectedToken = "O";

            var board = new Board(new []
            {
                "-", expectedToken, "-",
                "-", "-", "-",
                "-", "-", "-"
            });
            Assert.AreEqual(expectedToken, board.GetTokenAt(position));
        }

        [Test]
        public void GetLength()
        {
            var board = new Board(new []
            {
                "-", "-", "-"
            });

            Assert.AreEqual(3, board.Length);
        }

        [Test]
        [TestCase(new[]
        {
            "-", "-", "-",
            "-", "-", "-",
            "-", "-", "-"
        }, false)]
        [TestCase(new[]
        {
            "X", "O", "X",
            "O", "X", "O",
            "O", "X", "O"
        }, true)]
        [TestCase(new[]
        {
            "-", "O", "-",
            "O", "X", "-",
            "-", "-", "-"
        }, false)]
        public void CheckIfFilled(string[] inputBoard, bool isFilled)
        {
            var board = new Board(inputBoard);
            Assert.AreEqual(isFilled, board.IsFilled());
        }
    }
}

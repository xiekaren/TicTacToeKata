using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class BoardShould
    {
        [TestCase(new[]
        {
            "-", "-", "-",
            "-", "-", "-",
            "-", "-", "-"
        }, 1, "-")]
        [TestCase(new[]
        {
            "-", "-", "-",
            "-", "X", "-",
            "-", "-", "-"
        }, 5, "X")]
        public void GetSquare(string[] inputSquares, int position, string expectedSquare)
        {
            var board = new Board(inputSquares);
            Assert.AreEqual(expectedSquare, board.GetSquare(position));
        }

        [Test]
        public void SetSquare()
        {
            var board = new Board(new[]
            {
                "-", "-", "-",
                "-", "-", "-",
                "-", "-", "-"
            });
            board.SetSquare(1, "X");
            Assert.AreEqual("X", board.GetSquare(1));
        }

        [TestCase(new[]
        {
            "-", "-", "-",
            "-", "-", "-",
            "-", "-", "-"
        }, false)]
        [TestCase(new[]
        {
            "X", "O", "X",
            "X", "O", "O",
            "O", "X", "X"
        }, true)]
        public void CheckIfFilled(string[] input, bool expected)
        {
            var board = new Board(input);
            Assert.AreEqual(expected, board.IsFilled());
        }
    }
}

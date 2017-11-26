using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeShould
    {

        [Test]
        [TestCase(
            1, "O",

            " - | - | - \n" +
            "-----------\n" +
            " - | - | - \n" +
            "-----------\n" +
            " - | - | - ",

            " O | - | - \n" +
            "-----------\n" +
            " - | - | - \n" +
            "-----------\n" +
            " - | - | - ")]
        [TestCase(
            5, "X",

            " - | - | - \n" +
            "-----------\n" +
            " - | - | - \n" +
            "-----------\n" +
            " - | - | - ",

            " - | - | - \n" +
            "-----------\n" +
            " - | X | - \n" +
            "-----------\n" +
            " - | - | - ")]
        public void PlayTokenAtDesiredPosition(int position, string token, string initialGrid, string expectedGrid)
        {
            var game = new TicTacToe(new Renderer(), new Board(), new ComputerPlayer(), new HumanPlayer());
            var actualGrid = game.MakePlay(position, token);
            Assert.AreEqual(expectedGrid, actualGrid);
        }
    }
}

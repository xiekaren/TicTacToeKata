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
        public void PlayTokenAtDesiredPosition(int position, string token, string initialGrid, string expectedGrid)
        {
            var game = new TicTacToe(new Renderer(), new Board());
            var actualGrid = game.MakePlay(position, token);
            Assert.AreEqual(expectedGrid, actualGrid);
        }
    }
}

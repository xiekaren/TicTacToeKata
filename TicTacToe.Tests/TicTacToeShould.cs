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
            var actualGrid = game.MakePlay(token, position);
            Assert.AreEqual(expectedGrid, actualGrid);
        }

        [TestCase(
            "O", 5, "X", 6,

            " - | - | - \n" +
            "-----------\n" +
            " - | - | - \n" +
            "-----------\n" +
            " - | - | - ",

            " - | - | - \n" +
            "-----------\n" +
            " - | O | - \n" +
            "-----------\n" +
            " - | - | - ",
            
            " - | - | - \n" +
            "-----------\n" +
            " - | O | X \n" +
            "-----------\n" +
            " - | - | - ")]
        public void SaveGameState(string token1, int move1, string token2, int move2, string initialGrid, string expectedGrid1, string expectedGrid2)
        {
            var game = new TicTacToe(new Renderer(), new Board(), new ComputerPlayer(), new HumanPlayer());
            var actualGrid1 = game.MakePlay(token1, move1);
            Assert.AreEqual(expectedGrid1, actualGrid1);
            var actualGrid2 = game.MakePlay(token2, move2);
            Assert.AreEqual(expectedGrid2, actualGrid2);
        }
    }
}

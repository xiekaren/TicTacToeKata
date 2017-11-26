using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeShould
    {
        private Renderer _renderer;
        private Board _board;
        private ComputerPlayer _computerPlayer;
        private HumanPlayer _humanPlayer;

        [SetUp]
        public void SetUp()
        {
            _renderer = new Renderer();
            _board = new Board();
            _computerPlayer = new ComputerPlayer();
            _humanPlayer = new HumanPlayer();
        }

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
            var game = new TicTacToe(_renderer, _board, _computerPlayer, _humanPlayer);
            var actualGrid = game.MakePlay(token, position);
            Assert.AreEqual(expectedGrid, actualGrid);
        }

        [Test]
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
            var game = new TicTacToe(_renderer, _board, _computerPlayer, _humanPlayer);
            var actualGrid1 = game.MakePlay(token1, move1);
            Assert.AreEqual(expectedGrid1, actualGrid1);
            var actualGrid2 = game.MakePlay(token2, move2);
            Assert.AreEqual(expectedGrid2, actualGrid2);
        }

//        [Test]
        public void ChooseFirstFreePositionOnBoardToPlay()
        {
            const string initialGrid =  " - | - | - \n" +
                                        "-----------\n" +
                                        " - | - | - \n" +
                                        "-----------\n" +
                                        " - | - | - ";

            const string expectedGrid = " X | O | - \n" +
                                        "-----------\n" +
                                        " - | - | - \n" +
                                        "-----------\n" +
                                        " - | - | - ";

            var game = new TicTacToe(_renderer, _board, _computerPlayer, _humanPlayer);
            var initialFormattedGrid = _renderer.FormatBoardAsGrid(_board);
            Assert.AreEqual(initialGrid, initialFormattedGrid);

            game.MakePlay("X", 1);
            var actualGrid = game.MakePlay("O", _computerPlayer.GetDesiredMove(_board));
            Assert.AreEqual(expectedGrid, actualGrid);
        }
    }
}

using System;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeShould
    {
        private Renderer _renderer;
        private Board _board;
        private ComputerPlayer _computerPlayer;
        private WinChecker _winChecker;
        private InputChecker _inputChecker;
       
        [SetUp]
        public void SetUp()
        {
            _renderer = new Renderer();
            _board = new Board();
            _computerPlayer = new ComputerPlayer();
            _winChecker = new WinChecker();
            _inputChecker = new InputChecker();
        }

        [Test]
        [TestCase(
            1, "O",
            " O | - | - \n" +
            "-----------\n" +
            " - | - | - \n" +
            "-----------\n" +
            " - | - | - ")]
        [TestCase(
            5, "X",
            " - | - | - \n" +
            "-----------\n" +
            " - | X | - \n" +
            "-----------\n" +
            " - | - | - ")]
        public void PlayTokenAtDesiredPosition(int position, string token, string expectedGrid)
        {
            var game = new TicTacToe(_renderer, _board, _winChecker, _inputChecker);
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
            var game = new TicTacToe(_renderer, _board, _winChecker, _inputChecker);
            var actualGrid1 = game.MakePlay(token1, move1);
            Assert.AreEqual(expectedGrid1, actualGrid1);
            var actualGrid2 = game.MakePlay(token2, move2);
            Assert.AreEqual(expectedGrid2, actualGrid2);
        }

        [Test]
        public void ReturnStateWithComputerPlayerMove()
        {
            const string humanPlayerToken = "O";
            const int humanPlayerMove = 1;
            const string expectedGrid = " O | X | - \n" +
                                        "-----------\n" +
                                        " - | - | - \n" +
                                        "-----------\n" +
                                        " - | - | - ";

            var game = new TicTacToe(_renderer, _board, _winChecker, _inputChecker);
            game.MakePlay(humanPlayerToken, humanPlayerMove);
            var actualGrid = game.MakePlay(_computerPlayer.Token, _computerPlayer.Solve(_board));

            Assert.AreEqual(expectedGrid, actualGrid);
        }

        [Test]
        [TestCase(new[]
        {
            "X", "X", "-",
            "O", "O", "-",
            "-", "-", "-"
        }, 
            "X", 3, 
            "Computer wins!")]
        [TestCase(new[]
        {
            "X", "X", "-",
            "O", "O", "-",
            "-", "-", "-"
        },
            "O", 6,
            "You win!")]
        [TestCase(new[]
        {
            "X", "X", "O",
            "O", "O", "X",
            "-", "O", "X"
        },
            "X", 7,
            "Draw!")]
        public void PrintWinnerIfFound(string[] board, string tokenToPlay, int positionToPlay, string expectedMessage)
        {
            _board = new Board(board);
            var game = new TicTacToe(_renderer, _board, _winChecker, _inputChecker);

            game.MakePlay(tokenToPlay, positionToPlay);
            var winner = game.CheckWinner();
            var actualMessage = _renderer.FormatWinnerMessage(winner);
            
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        //[Test]
        //[TestCase("X", -1, "Please choose a position on the board (1-9).")]
        public void GiveInputErrorMessageIfPlayIsInvalid(string token, int position, string expectedMessage)
        {
            var game = new TicTacToe(_renderer, _board, _winChecker, _inputChecker);

            Assert.That(() => game.MakePlay(token, position), 
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo(expectedMessage));
        }
    }
}

using NUnit.Framework;
using TicTacToe.Checker;
using TicTacToe.GameElements;
using TicTacToe.Interface;
using TicTacToe.Player;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeShould
    {
        private Renderer _renderer;
        private Board _board;
        private ComputerPlayer _computerPlayer;
        private WinChecker _winChecker;
        private HumanPlayer _humanPlayer;

        [SetUp]
        public void SetUp()
        {
            _renderer = new Renderer();
            _board = new Board();
            _computerPlayer = new ComputerPlayer();
            _winChecker = new WinChecker();
            _humanPlayer = new HumanPlayer(new InputChecker());
        }

//        [Test]
//        [TestCase(new[]
//        {
//            "X", "X", "-",
//            "O", "O", "-",
//            "-", "-", "-"
//        }, 
//            "X", 3, 
//            "Computer wins!")]
//        [TestCase(new[]
//        {
//            "X", "X", "-",
//            "O", "O", "-",
//            "-", "-", "-"
//        },
//            "O", 6,
//            "You win!")]
//        [TestCase(new[]
//        {
//            "X", "X", "O",
//            "O", "O", "X",
//            "-", "O", "X"
//        },
//            "X", 7,
//            "Draw!")]
//        public void PrintWinnerIfFound(string[] board, string tokenToPlay, int positionToPlay, string expectedMessage)
//        {
//            _board = new Board(board);
//            var game = new TicTacToe(_renderer, _board, _winChecker, _computerPlayer, _humanPlayer);
//
//            game.MakePlay(tokenToPlay, positionToPlay);
//            var winner = game.CheckWinner();
//            var actualMessage = _renderer.FormatWinnerMessage(winner);
//            
//            Assert.AreEqual(expectedMessage, actualMessage);
//        }
    }
}

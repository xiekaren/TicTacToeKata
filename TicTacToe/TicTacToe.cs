using System;
using TicTacToe.Checker;
using TicTacToe.GameElements;
using TicTacToe.Interface;
using TicTacToe.Player;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Renderer _renderer;
        private readonly Board _board;
        private readonly WinChecker _winChecker;
        private readonly ComputerPlayer _computerPlayer;
        private readonly HumanPlayer _humanPlayer;

        private IPlayer _currentPlayer;
        private string _currentToken;

        public TicTacToe(Renderer renderer, Board board, WinChecker winChecker, ComputerPlayer computerPlayer, HumanPlayer humanPlayer)
        {
            _renderer = renderer;
            _board = board;
            _winChecker = winChecker;
            _computerPlayer = computerPlayer;
            _humanPlayer = humanPlayer;

            _currentPlayer = _computerPlayer;
            _currentToken = "X";
        }

        public void Play()
        {
            while (!GameFinished())
            {
                Console.WriteLine(_renderer.FormatBoardAsGrid(_board));
                var move = _currentPlayer.Solve(_board);
                _board.PlaceTokenAt(_currentToken, move);
                UpdateCurrentPlayer();
            }

            Console.WriteLine(_renderer.FormatBoardAsGrid(_board));
            var winner = _winChecker.GetWinner(_board);
            Console.WriteLine(_renderer.FormatWinnerMessage(winner));
        }

        private void UpdateCurrentPlayer()
        {
            if (_currentPlayer.GetType() == typeof(HumanPlayer))
            {
                _currentPlayer = _computerPlayer;
                _currentToken = "X";
            }
            else
            {
                _currentPlayer = _humanPlayer;
                _currentToken = "O";
            }
        }

        private bool GameFinished()
        {
            return _board.IsFilled() || _winChecker.GetWinner(_board) != "";
        }
    }
}

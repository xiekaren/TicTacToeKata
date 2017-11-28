using System;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Board _board;
        private readonly WinChecker _winChecker;
        private readonly Display _display;
        private readonly IPlayer _computerPlayer;
        private readonly IPlayer _humanPlayer;

        public string _currentPlayerToken = "X";
        public IPlayer _currentPlayer;

        public TicTacToe(Board board, Display display, WinChecker winChecker, IPlayer computerPlayer, IPlayer humanPlayer)
        {
            _board = board;
            _display = display;
            _winChecker = winChecker;
            _computerPlayer = computerPlayer;
            _humanPlayer = humanPlayer;
            _currentPlayer = computerPlayer;
        }

        public void Play()
        {
            while (!IsFinished())
            {
                Console.WriteLine(_display.RenderBoard(_board));
                Console.WriteLine(_display.RenderInstructions());

                var move = _currentPlayer.Solve(_board);
                _board.SetSquare(move, _currentPlayerToken);

                ToggleCurrentPlayer();
            }
        }

        private bool IsFinished()
        {
            return _board.IsFilled() || _winChecker.GetWinner(_board) != "";
        }

        public void ToggleCurrentPlayer()
        {
            _currentPlayerToken = _currentPlayerToken == "X" ? "O" : "X";
            _currentPlayer = _computerPlayer.GetType() == typeof(ComputerPlayer) ? _humanPlayer : _computerPlayer;
        }
    }
}

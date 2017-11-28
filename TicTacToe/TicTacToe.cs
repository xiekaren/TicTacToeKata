using System;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Board _board;
        private readonly WinChecker _winChecker;
        private readonly Display _display;
        private readonly IPlayer _player1;
        private readonly IPlayer _player2;

        public const string XToken = "X";
        public const string OToken = "O";
        public string CurrentPlayerToken = XToken;
        public IPlayer CurrentPlayer;

        public TicTacToe(Board board, Display display, WinChecker winChecker, IPlayer player1, IPlayer player2)
        {
            _board = board;
            _display = display;
            _winChecker = winChecker;
            _player1 = player1;
            _player2 = player2;
            CurrentPlayer = player1;
        }

        public void Play()
        {
            while (!IsFinished())
            {
                Console.WriteLine(_display.RenderBoard(_board));
                Console.WriteLine(_display.RenderInstructions());

                var move = CurrentPlayer.Solve(_board);
                _board.SetSquare(move, CurrentPlayerToken);

                ToggleCurrentPlayer();
            }

            Console.WriteLine(_display.RenderBoard(_board));
            var winner = _winChecker.GetWinner(_board);
            Console.WriteLine(_display.RenderWin(winner));
        }

        private bool IsFinished()
        {
            return _board.IsFilled() || _winChecker.GetWinner(_board) != "";
        }

        private void ToggleCurrentPlayer()
        {
            if (CurrentPlayerToken == XToken)
            {
                CurrentPlayerToken = OToken;
                CurrentPlayer = _player2;
            }
            else
            {
                CurrentPlayerToken = XToken;
                CurrentPlayer = _player1;
            }
        }
    }
}

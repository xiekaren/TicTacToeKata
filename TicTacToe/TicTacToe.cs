using System.Text;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Board _board;
        private readonly WinChecker _winChecker;

        public string CurrentPlayer = "X";
        
        public TicTacToe(Board board, WinChecker winChecker)
        {
            _board = board;
            _winChecker = winChecker;
        }

        public bool IsFinished()
        {
            return _board.IsFilled() || _winChecker.GetWinner(_board) != "";
        }

        public void ToggleCurrentPlayer()
        {
            CurrentPlayer = CurrentPlayer == "X" ? "O" : "X";
        }
    }
}

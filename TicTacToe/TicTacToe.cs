using System.Text;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Board _board;
        public string CurrentPlayer = "X";

        public TicTacToe(Board board)
        {
            _board = board;
        }

        public void ToggleCurrentPlayer()
        {
            CurrentPlayer = CurrentPlayer == "X" ? "O" : "X";
        }
    }
}

namespace TicTacToe
{
    public class Board
    {
        private string _board;

        public Board(string input)
        {
            _board = input;
        }

        public bool IsFilled()
        {
            return !_board.Contains(" ");
        }
    }
}
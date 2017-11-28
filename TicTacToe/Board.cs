namespace TicTacToe
{
    public class Board
    {
        private const string BlankSquare = "-";
        private string[] _squares;

        public Board(string[] input)
        {
            _squares = input;
        }

        public Board()
        {
            _squares = new string[9];
            for (var i = 0; i < 9; i++)
            {
                _squares[i] = BlankSquare;
            }
        }

        public string GetSquare(int i)
        {
            return _squares[i - 1];
        }
    }
}
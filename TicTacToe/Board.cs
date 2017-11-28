using System.Linq;

namespace TicTacToe
{
    public class Board
    {
        public const string BlankSquare = "-";
        private readonly string[] _squares;
        public int Length => _squares.Length;

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

        public string GetSquare(int position)
        {
            return _squares[position - 1];
        }

        public void SetSquare(int position, string value)
        {
            _squares[position - 1] = value;
        }

        public bool IsFilled()
        {
            return _squares.All(s => s != BlankSquare);
        }
    }
}
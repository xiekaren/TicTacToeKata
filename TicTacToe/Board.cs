using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        private readonly List<string> _board;
        private const int NumSpaces = 9;

        public Board()
        {
            _board = new List<string>();
            for (var i = 0; i < NumSpaces; i++)
            {
                _board.Add("");
            }
        }

        public int GetLength()
        {
            return _board.Count;
        }

        public void SetValue(int position, string value)
        {
            _board[position] = value;
        }

        public string GetValueAt(int position)
        {
            return _board[position];
        }
    }
}

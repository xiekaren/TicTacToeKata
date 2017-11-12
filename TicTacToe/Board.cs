using System;
using System.Collections;

namespace TicTacToe
{
    public class Board
    {
        private readonly Hashtable _board;

        public Board(int width, int height)
        {
            _board = new Hashtable();
            Initialise(width, height);
        }

        private void Initialise(int width, int height)
        {
            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    var key = $"{i}{j}";
                    _board.Add(key, "");
                }
            }
        }

        public string Get(int x, int y)
        {
            var key = $"{x}{y}";

            if (_board.ContainsKey(key))
            {
                return (string)_board[key];
            }

            throw new ArgumentException("Position is not on grid.");
        }

        public void Set(int x, int y, string value)
        {
            var key = $"{x}{y}";
            _board[key] = value;
        }
    }
}

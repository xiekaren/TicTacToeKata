using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class TicTacToe
    {
        private const int Width = 3;
        private const int Height = 3;

        public int Solve(string board)
        {
            return board.IndexOf(" ", StringComparison.Ordinal);
        }

        public string MakePlay(string board, string token, int position)
        {
            ValidatePlay(board, position);
            var newBoard = new StringBuilder(board) {[position] = char.Parse(token)};
            return newBoard.ToString();
        }

        public bool IsEndOfGame(string board)
        {
            return !board.Contains(" ");
        }

        public bool CheckRowWin(string board)
        {
            var rows = Enumerable.Range(0, board.Length / 3).Select(i => board.Substring(i * 3, 3));
            return rows.Any(r => r == "XXX" || r == "OOO");
        }

        private static void ValidatePlay(string board, int position)
        {
            if (position >= board.Length || position < 0)
            {
                throw new ArgumentException("Position is not on the board.");
            }

            if (board[position] != ' ')
            {
                throw new ArgumentException("Position has been taken.");
            }
        }

    }
}
using System;
using System.Text;

namespace TicTacToe
{
    public class TicTacToe
    {
        public int Solve(string board)
        {
            return board.IndexOf(" ", StringComparison.Ordinal);
        }

        public string MakePlay(string board, string token, int position)
        {
            var newBoard = new StringBuilder(board) {[position] = char.Parse(token)};
            return newBoard.ToString();
        }
    }
}
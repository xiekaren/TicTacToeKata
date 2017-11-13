using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Solver
    {
        public int Solve(List<string> board)
        {
            return 0;
        }

        public bool CanWin(string line, string playerToken)
        {
            return line.Count(x => x.ToString() == playerToken) == 2 && line.Contains(" ");
        }

        public bool IsValid(string board, int position)
        {
            if (position >= board.Length || position < 0)
            {
                throw new ArgumentException("Position is not on the board.");
            }

            if (board[position] != ' ')
            {
                throw new ArgumentException("Position has been taken.");
            }

            return true;
        }

        public string[] GetRows(string board)
        {
            return new[] {""};
        }
    }
}
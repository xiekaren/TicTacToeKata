using System;
using System.Linq;

namespace TicTacToe
{
    public class StateChecker
    {
        public bool IsEndOfGame(string board)
        {
            return !board.Contains(" ");
        }

        public bool IsWin(string line)
        {
            return line.Distinct().Count() == 1;
        }

        public string CheckForWinner(Board board)
        {
            foreach (var row in board.GetRows())
            {
                if (IsWin(row)) return row.First().ToString();
            }
            foreach (var diagonal in board.GetDiagonals())
            {
                if (IsWin(diagonal)) return diagonal.First().ToString();
            }
            foreach (var column in board.GetColumns())
            {
                if (IsWin(column)) return column.First().ToString();
            }
            return "";
        }
    }
}

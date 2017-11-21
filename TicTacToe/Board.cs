using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Board
    {
        private const string EmptyPosition = "-";
        private readonly string _board;
        private readonly List<List<int>> _winningPositions;

        public Board() {}

        public Board(string input)
        {
            _board = input;
            _winningPositions = new List<List<int>>
            {
                new List<int> {0, 1, 2}, new List<int> {3, 4, 5}, new List<int> {6, 7, 8},
                new List<int> {0, 3, 6}, new List<int> {1, 4, 7}, new List<int> {2, 5, 8},
                new List<int> {0, 4, 8}, new List<int> {2, 4, 6}
            };
        }

        public string Get()
        {
            return _board;
        }

        public virtual bool IsFilled()
        {
            return !_board.Contains(EmptyPosition);
        }

        public virtual string GetWinner()
        {
            foreach (var winningCombo in _winningPositions)
            {
                var line = winningCombo.Aggregate("", (current, position) => current + _board[position]);
                if (IsWinningLine(line))
                {
                    return GetTokenAtFirstPosition(line);
                }
            }
            return "";
        }

        private static string GetTokenAtFirstPosition(string line)
        {
            return line[0].ToString();
        }

        private static bool IsWinningLine(string line)
        {
            return line.Distinct().Count() == 1 && !line.Contains(EmptyPosition);
        }

    }
}
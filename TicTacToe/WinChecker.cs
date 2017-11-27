﻿using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class WinChecker
    {
        private readonly List<List<int>> _winningCombos;

        public WinChecker()
        {
            _winningCombos = new List<List<int>>
            {
                new List<int> {1,2,3},
                new List<int> {4,5,6},
                new List<int> {7,8,9},

                new List<int> {1,4,7},
                new List<int> {2,5,8},
                new List<int> {3,6,9},

                new List<int> {1,5,9},
                new List<int> {3,5,7}
            };
        }

        public string GetWinner(Board board)
        {
            foreach (var winningCombo in _winningCombos)
            {
                var line = AggregateLine(board, winningCombo);
                if (IsWin(line)) return line.First().ToString();
            }

            return "";
        }

        private static string AggregateLine(Board board, IEnumerable<int> winningCombo)
        {
            return winningCombo.Aggregate("", (current, position) => current + board.GetTokenAt(position));
        }

        private static bool IsWin(string line)
        {
            return line.Distinct().Count() == 1 && !line.Contains("-");
        }
    }
}
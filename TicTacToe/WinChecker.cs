using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class WinChecker
    {
        private List<List<int>> WinningCombos;

        public WinChecker()
        {
            WinningCombos = new List<List<int>>
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
            foreach (var winningCombo in WinningCombos)
            {
                var line = winningCombo.Aggregate("", (current, position) => current + board.GetTokenAt(position));
                if (line.Distinct().Count() == 1 && !line.Contains("-")) return line[0].ToString();
            }

            return "";
        }
    }
}
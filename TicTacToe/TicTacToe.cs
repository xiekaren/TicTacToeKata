using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class TicTacToe
    {
        public int Solve(List<string> board)
        {
            return 0;
        }

        public bool CanWin(string line, string playerToken)
        {
            return line.Count(x => x.ToString() == playerToken) == 2 && line.Contains(" ");
        }

        public List<string> GetRows(string board, int rowWidth, int numRows)
        {
            var rows = new List<string>();

            for (var i = 0; i < numRows; i++)
            {
                var row = "";

                for (var j = 0; j < rowWidth; j++)
                {
                    row += board[3*i + j];
                }
                rows.Add(row);
            }

            return rows;
        }
    }
}
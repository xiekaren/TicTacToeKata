using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class TicTacToe
    {
        public int Solve(string board)
        {
            return board.IndexOf(" ", StringComparison.Ordinal);
        }
    }
}
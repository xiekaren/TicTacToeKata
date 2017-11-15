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
    }
}

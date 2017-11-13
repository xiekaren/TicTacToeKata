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
    }
}

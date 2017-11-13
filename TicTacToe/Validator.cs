using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Validator
    {
        public bool IsValidPlay(string board, int position)
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
    }
}

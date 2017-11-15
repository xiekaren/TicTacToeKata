using System;

namespace TicTacToe
{
    public class Validator
    {
        public void ValidatePlay(string board, int position)
        {
            if (position >= board.Length || position < 0)
            {
                throw new ArgumentException("Position is not on the board.");
            }

            if (board[position] != ' ')
            {
                throw new ArgumentException("Position has been taken.");
            }
        }
    }
}

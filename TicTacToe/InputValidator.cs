using System;

namespace TicTacToe
{
    public class InputValidator
    {
        public void ValidateMove(Board board, string inputMove)
        {
            var position = -1;
            if (!int.TryParse(inputMove, out position))
                throw new ArgumentException("Please choose a number between 0 and 8");

            if (position >= board.Grid.Length || position < 0)
                throw new ArgumentException("Please choose a position on the board.");

            if (board.Grid[position].ToString() != "-")
                throw new ArgumentException("Please choose an empty position on the board.");
        }
    }
}

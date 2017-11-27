using System;

namespace TicTacToe
{
    public class InputChecker
    {
        public void Validate(Board board, string input)
        {
            int inputAsNumber;

            if (!int.TryParse(input, out inputAsNumber))
                throw new ArgumentException("Please enter a position from 1 to 9.");

            if (inputAsNumber < 0 || inputAsNumber > board.Length)
                throw new ArgumentException("Please enter a position from 1 to 9.");

            if (board.GetTokenAt(inputAsNumber) != "-")
                throw new ArgumentException("Please enter an unoccupied position from 1 to 9.");
        }
    }
}
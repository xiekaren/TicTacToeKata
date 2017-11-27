using System;
using TicTacToe.GameElements;

namespace TicTacToe.Checker
{
    public class InputChecker
    {
        private const string EnterAPositionOnTheBoard = "Please enter a position from 1 to 9.";
        private const string EnterAnUnoccupiedPosition = "Please enter an unoccupied position from 1 to 9.";

        public void Validate(Board board, string input)
        {
            int inputAsNumber;

            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out inputAsNumber) || inputAsNumber < 0 || inputAsNumber > board.Length)
                throw new ArgumentException(EnterAPositionOnTheBoard);

            if (board.GetTokenAt(inputAsNumber) != "-")
                throw new ArgumentException(EnterAnUnoccupiedPosition);
        }
    }
}
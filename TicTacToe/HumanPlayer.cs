using System;

namespace TicTacToe
{
    public class HumanPlayer : IPlayer
    {
        public int Solve(Board board)
        {
            while (true)
            {
                var input = Console.ReadLine();
                int inputAsNumber;

                if (int.TryParse(input, out inputAsNumber) && 
                    inputAsNumber > 0 && inputAsNumber < board.Length)
                {
                    return inputAsNumber;
                }

                Console.WriteLine("Please enter a position 1-9 that is empty.");
            }
        }
    }
}
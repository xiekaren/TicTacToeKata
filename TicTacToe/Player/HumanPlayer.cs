using System;
using TicTacToe.Checker;
using TicTacToe.GameElements;

namespace TicTacToe.Player
{
    public class HumanPlayer : IPlayer
    {
        private readonly InputChecker _inputChecker;
        
        public HumanPlayer(InputChecker inputChecker)
        {
            _inputChecker = inputChecker;
        }

        public int Solve(Board board)
        {
            while (true)
            {
                try
                {
                    var input = Console.ReadLine();
                    _inputChecker.Validate(board, input);
                    return int.Parse(input);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }  
}
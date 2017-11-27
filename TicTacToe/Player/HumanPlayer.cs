using System;
using TicTacToe.Checker;
using TicTacToe.GameElements;

namespace TicTacToe.Player
{
    public class HumanPlayer : IPlayer
    {
        private readonly InputChecker _inputChecker;
        private readonly ConsoleWrapper _consoleWrapper;

        public HumanPlayer(InputChecker inputChecker, ConsoleWrapper consoleWrapper)
        {
            _inputChecker = inputChecker;
            _consoleWrapper = consoleWrapper;
        }

        public int Solve(Board board)
        {
            while (true)
            {
                try
                {
                    var input = _consoleWrapper.ReadLine();
                    _inputChecker.Validate(board, input);
                    return int.Parse(input);
                }
                catch (ArgumentException e)
                {
                    _consoleWrapper.WriteLine(e.Message);
                }
            }

        }
    }

    public class ConsoleWrapper
    {
        public virtual string ReadLine()
        {
            return Console.ReadLine();
        }

        public virtual void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
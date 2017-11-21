using System;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    public class Prompt
    {
        private readonly InputValidator _validator;

        public Prompt()
        {
        }

        public Prompt(InputValidator validator)
        {
            _validator = validator;
        }

        public virtual void PrintWinner(string winner = "")
        {
            if (winner == "")
            {
                Console.Write("Draw!");
            }
            else
            {
                Console.WriteLine($"Player {winner} is the winner!");
            }
        }

        public virtual void PrintGameEnded()
        {
            Console.WriteLine("Game finished.\n" +
                              "Press ENTER to play again. Press anything else to quit.");
        }

        public void PrintInstructions()
        {
            Console.WriteLine("Please enter a position between 0 and 8.");
        }

        public virtual void PrintFormattedBoard(Board board)
        {
            Console.WriteLine(FormatBoard(board));
        }

        public string FormatBoard(Board board)
        {
            return Regex.Replace(board.Grid, ".{3}", "$\n");
        }

        public int ReadValidPlayerMove(Board board)
        {
            while (true)
            {
                try
                {
                    var inputMove = Console.ReadLine();
                    _validator.ValidateMove(board, inputMove);
                    return int.Parse(inputMove);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public bool ReadShouldPlayAgain()
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                return true;
            }
            Environment.Exit(0);
            return false;
        }
    }
}
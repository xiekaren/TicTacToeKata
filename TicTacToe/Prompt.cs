using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    public class Prompt
    {
        private readonly InputValidator _validator;

        public Prompt() { }

        public Prompt(InputValidator validator)
        {
            _validator = validator;
        }

        public virtual void PrintWinner(string winner = "")
        {
        }

        public virtual void PrintGameEnded()
        {
            
        }

        public virtual void PrintFormattedBoard(Board board)
        {
            Console.WriteLine(FormatBoard(board));
        }

        public string FormatBoard(Board board)
        {
            return Regex.Replace(board.Grid, ".{3}", "$0\n");
        }

        public int ReadValidPlayerMove(Board board, string inputMove)
        {
            while (true)
            {
                try
                {
                    _validator.ValidateMove(board, inputMove);
                    return int.Parse(inputMove);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    public class UserInterface
    {
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
            return Regex.Replace(board.Get(), ".{3}", "$0\n");
        }

        public virtual string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}
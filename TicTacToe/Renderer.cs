using System.Text.RegularExpressions;

namespace TicTacToe
{
    public class Renderer
    {
        public virtual void PrintWinner(string winner = "")
        {
        }

        public virtual void PrintGameEnded()
        {
            
        }

        public void PrintBoard(Board board)
        {
            
        }

        public string FormatBoard(Board board)
        {
            return Regex.Replace(board.Get(), ".{3}", "$0\n");
        }
    }
}
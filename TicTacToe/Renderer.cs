using System.Text;

namespace TicTacToe
{
    public class Renderer
    {
        public string FormatBoardAsGrid(Board board)
        {
            var formattedBoard = new StringBuilder();

            formattedBoard.Append(" " + board.GetTokenAt(1) + " | " + board.GetTokenAt(2) + " | " + board.GetTokenAt(3) + " ");
            formattedBoard.Append("\n-----------\n");
            formattedBoard.Append(" " + board.GetTokenAt(4) + " | " + board.GetTokenAt(5) + " | " + board.GetTokenAt(6) + " ");
            formattedBoard.Append("\n-----------\n");
            formattedBoard.Append(" " + board.GetTokenAt(7) + " | " + board.GetTokenAt(8) + " | " + board.GetTokenAt(9) + " ");

            return formattedBoard.ToString();
        }
    }
}
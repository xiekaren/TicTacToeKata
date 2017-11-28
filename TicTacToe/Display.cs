using System.Text;

namespace TicTacToe
{
    public class Display
    {
        public string RenderBoard(Board board)
        {
            var formattedBoard = new StringBuilder();

            formattedBoard.Append(" " + board.GetSquare(1) + " | " + board.GetSquare(2) + " | " + board.GetSquare(3) + " ");
            formattedBoard.Append("\n-----------\n");
            formattedBoard.Append(" " + board.GetSquare(1) + " | " + board.GetSquare(2) + " | " + board.GetSquare(3) + " ");
            formattedBoard.Append("\n-----------\n");
            formattedBoard.Append(" " + board.GetSquare(1) + " | " + board.GetSquare(2) + " | " + board.GetSquare(3) + " ");

            return formattedBoard.ToString();
        }
    }
}
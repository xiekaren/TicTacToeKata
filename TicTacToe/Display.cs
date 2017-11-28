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

        public string RenderInstructions()
        {
            return "Please enter an unoccupied position from 1-9.";
        }

        public string RenderWin(string winner)
        {
            if (winner == "")
            {
                return "Draw!";
            }

            return $"Player {winner} wins!";
        }
    }
}
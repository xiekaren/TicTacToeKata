using System.Text;

namespace TicTacToe
{
    public class Display
    {
        public string RenderBoard(Board board)
        {
            var formattedBoard = new StringBuilder();

            formattedBoard.Append("\n " + board.GetSquare(1) + " | " + board.GetSquare(2) + " | " + board.GetSquare(3) + " ");
            formattedBoard.Append("\n-----------\n");
            formattedBoard.Append(" " + board.GetSquare(4) + " | " + board.GetSquare(5) + " | " + board.GetSquare(6) + " ");
            formattedBoard.Append("\n-----------\n");
            formattedBoard.Append(" " + board.GetSquare(7) + " | " + board.GetSquare(8) + " | " + board.GetSquare(9) + " \n");

            return formattedBoard.ToString();
        }

        public string RenderInstructions()
        {
            return "Please enter an unoccupied position from 1-9.";
        }

        public string RenderWin(string winner)
        {
            if (string.IsNullOrEmpty(winner))
            {
                return "Draw!";
            }
            if (winner == TicTacToe.XToken || winner == TicTacToe.OToken)
            {
                return $"Player {winner} wins!";
            }
            return "";
        }
    }
}
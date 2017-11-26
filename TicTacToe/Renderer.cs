using System.Text;

namespace TicTacToe
{
    public class Renderer
    {
        private const string RowSeparator = "\n-----------\n";
        private const string ColumnSeparator = "|";

        public string FormatBoardAsGrid(Board board)
        {
            var formattedBoard = new StringBuilder();

            for (var position = 0; position < board.Length; position++)
            {
                formattedBoard.Append(MakeCell(board.Cell(position)));

                if (ShouldAppendColumnSeparator(position))
                {
                    formattedBoard.Append(ColumnSeparator);
                }

                if (ShouldAppendRowSeparator(position))
                {
                    formattedBoard.Append(RowSeparator);
                }
            }

            return formattedBoard.ToString();
        }

        private static bool ShouldAppendRowSeparator(int position)
        {
            return position % Board.RowWidth == 2 && position != 8;
        }

        private static bool ShouldAppendColumnSeparator(int position)
        {
            return position % Board.RowWidth < 2;
        }

        private static string MakeCell(string token)
        {
            return " " + token + " ";
        }
    }
}
namespace TicTacToe
{
    public class Board
    {
        public const int RowWidth = 3;

        public int Length => _cells.Length;
        public string Cell(int position) => _cells[position];

        private readonly string[] _cells;

        public Board()
        {
            _cells = new[]
            {
                "-", "-", "-",
                "-", "-", "-",
                "-", "-", "-"
            };
        }

        public Board(string[] cells)
        {
            _cells = cells;
        }

        public void PlaceTokenAtPosition(string token, int position)
        {
            var cellPosition = position - 1;
            _cells[cellPosition] = token;
        }
    }
}
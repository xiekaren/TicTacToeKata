namespace TicTacToe.GameElements
{
    public class Board
    {
        private readonly string[] _cells;
        public int Length => _cells.Length;

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

        public void PlaceTokenAt(string token, int position)
        {
            var cellPosition = position - 1;
            _cells[cellPosition] = token;
        }

        public string GetTokenAt(int position)
        {
            return _cells[position - 1];
        }
    }
}
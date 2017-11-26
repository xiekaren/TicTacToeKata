namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Renderer _renderer;
        private readonly Board _board;
        private readonly WinChecker _winChecker;

        public TicTacToe(Renderer renderer, Board board, WinChecker winChecker)
        {
            _renderer = renderer;
            _board = board;
            _winChecker = winChecker;
        }

        public string MakePlay(string token, int position)
        {
            _board.PlaceTokenAt(token, position);
            return _renderer.FormatBoardAsGrid(_board);
        }

        public string CheckWinner()
        {
            return _winChecker.GetWinner(_board);
        }
    }
}

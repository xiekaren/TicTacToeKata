namespace TicTacToe
{
    public class TicTacToeGame
    {
        private readonly Renderer _renderer;
        private Board _board;

        public TicTacToeGame(Renderer renderer, Board board)
        {
            _renderer = renderer;
            _board = board;
        }

        public void Start()
        {
            if (_board.IsFilled())
            {
                _renderer.PrintWinner();
            }
        }
    }
}
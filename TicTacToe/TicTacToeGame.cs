using System.Linq;

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
            if (!_board.IsFilled()) return;

            var winner = _board.GetWinner();
            _renderer.PrintWinner(winner);
        }
    }
}
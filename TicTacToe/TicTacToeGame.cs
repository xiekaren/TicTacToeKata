using System.Linq;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        private readonly Renderer _renderer;
        private readonly Board _board;

        public TicTacToeGame(Renderer renderer, Board board)
        {
            _renderer = renderer;
            _board = board;
        }

        public void Start()
        {
            var winner = _board.GetWinner();
            _renderer.PrintWinner(winner);
        }
    }
}
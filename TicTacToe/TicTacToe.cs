using System.Text;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Board _board;
        public string CurrentPlayer = "X";
        private readonly GameState _gameState;

        public TicTacToe(Board board, GameState gameState)
        {
            _board = board;
            _gameState = gameState;
        }

        public bool IsFinished()
        {
            return _gameState.HasEnded(_board);
        }
    }
}

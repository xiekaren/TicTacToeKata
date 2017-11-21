using System;
using System.Linq;
using System.Linq.Expressions;

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

            if (_board.IsFilled())
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            _renderer.PrintGameEnded();
        }
    }
}
using System;
using System.Text;

namespace TicTacToe
{
    public class Game
    {
        private readonly Renderer _renderer;
        private readonly Board _board;

        public Game(Renderer renderer, Board board)
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

        public Board MakePlay(string token, int position)
        {
            if (position >= _board.Get().Length || position < 0)
                throw new ArgumentException("Please choose a position on the board.");

            if (_board.Get()[position].ToString() != "-")
                throw new ArgumentException("Please choose an empty position on the board.");

            var newBoard = new StringBuilder(_board.Get());
            newBoard[position] = Convert.ToChar(token);
            return new Board(newBoard.ToString());
        }

        public int Solve(Board board)
        {
            return board.Get().IndexOf("-", StringComparison.Ordinal);
        }
    }
}
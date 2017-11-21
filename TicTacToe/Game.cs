using System;
using System.Text;

namespace TicTacToe
{
    public class Game
    {
        private readonly Prompt _prompt;
        private Board _board;

        public Game(Prompt prompt, Board board)
        {
            _prompt = prompt;
            _board = board;
        }

        public void Start()
        {
            _prompt.PrintFormattedBoard(_board);
            var winner = _board.GetWinner();
            _prompt.PrintWinner(winner);

            if (_board.IsFilled())
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            _prompt.PrintGameEnded();
        }

        public Board MakePlay(string token, int position)
        {
            return _board.PlaceToken(token, position);
        }

        public int Solve(Board board)
        {
            return board.Grid.IndexOf("-", StringComparison.Ordinal);
        }
    }
}
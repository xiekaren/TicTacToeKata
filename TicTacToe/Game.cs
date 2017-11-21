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
            while (true)
            {
                _prompt.PrintInstructions();
                _prompt.PrintFormattedBoard(_board);

                MakePlayerMove();
                MakeComputerMove();

                var winner = _board.GetWinner();
                var isFilled = _board.IsFilled();

                if (winner != "" || isFilled)
                {
                    _prompt.PrintFormattedBoard(_board);
                    _prompt.PrintWinner(winner);
                    EndGame();
                }
            }
        }

        private void MakePlayerMove()
        {
            var playerMove = _prompt.ReadValidPlayerMove(_board);
            _board = MakePlay("O", playerMove);
        }

        private void MakeComputerMove()
        {
            var computerMove = Solve(_board);
            if (computerMove != -1)
            {
                _board = MakePlay("X", computerMove);
            }
        }

        private void EndGame()
        {
            _prompt.PrintGameEnded();
            _prompt.ReadShouldPlayAgain();
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
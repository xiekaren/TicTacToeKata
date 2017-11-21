using System;
using System.Text;

namespace TicTacToe
{
    public class Game
    {
        private readonly UserInterface _userInterface;
        private readonly Board _board;

        public Game(UserInterface userInterface, Board board)
        {
            _userInterface = userInterface;
            _board = board;
        }

        public void Start()
        {
            _userInterface.PrintFormattedBoard(_board);
            var desiredMove = _userInterface.ReadInput();

            var winner = _board.GetWinner();
            _userInterface.PrintWinner(winner);

            if (_board.IsFilled())
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            _userInterface.PrintGameEnded();
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
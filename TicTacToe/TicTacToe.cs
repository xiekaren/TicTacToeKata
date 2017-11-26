using System;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Renderer _renderer;
        private readonly Board _board;

        public TicTacToe(Renderer renderer, Board board)
        {
            _renderer = renderer;
            _board = board;
        }

        public string MakePlay(int position, string token)
        {
            _board.PlaceTokenAtPosition(token, position);
            return _renderer.FormatBoardAsGrid(_board);
        }
    }
}

using System;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Renderer _renderer;
        private readonly Board _board;
        private IPlayer _player1;
        private IPlayer _player2;

        public TicTacToe(Renderer renderer, Board board, IPlayer computerPlayer, IPlayer humanPlayer)
        {
            _renderer = renderer;
            _board = board;
            _player1 = computerPlayer;
            _player2 = humanPlayer;
        }

        public string MakePlay(string token, int position)
        {
            _board.PlaceTokenAtPosition(token, position);
            return _renderer.FormatBoardAsGrid(_board);
        }
    }
}

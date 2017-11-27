using System;
using TicTacToe.GameElements;

namespace TicTacToe.Player
{
    public class HumanPlayer  : IPlayer
    {
        public readonly string Token = "O";

        public int Solve(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
using TicTacToe.GameElements;

namespace TicTacToe.Player
{
    public interface IPlayer
    {
        int Solve(Board board);
    }
}
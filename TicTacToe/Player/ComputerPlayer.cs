using TicTacToe.GameElements;

namespace TicTacToe.Player
{
    public class ComputerPlayer : IPlayer
    {
        public int Solve(Board board)
        {
            for (var i = 1; i <= board.Length; i++)
            {
                if (board.GetTokenAt(i) == "-") return i;
            }
            return -1;
        }
    }
}
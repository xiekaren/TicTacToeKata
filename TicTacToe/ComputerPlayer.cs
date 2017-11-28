namespace TicTacToe
{
    public class ComputerPlayer : IPlayer
    {
        public int Solve(Board board)
        {
            for (var i = 1; i <= board.Length; i++)
            {
                if (board.GetSquare(i) == Board.BlankSquare)
                    return i;
            }
            return -1;
        }
    }
}
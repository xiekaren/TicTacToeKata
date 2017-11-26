namespace TicTacToe
{
    public interface IPlayer
    {
        int Solve(Board board);
    }

    public class HumanPlayer : IPlayer
    {
        public int Solve(Board board)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ComputerPlayer : IPlayer
    {
        public int Solve(Board board)
        {
            throw new System.NotImplementedException();
        }
    }

}

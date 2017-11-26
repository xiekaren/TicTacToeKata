namespace TicTacToe
{
    public interface IPlayer
    {
        int GetDesiredMove(Board board);
        string Token { get; set; }
    }

    public class HumanPlayer : IPlayer
    {
        public int GetDesiredMove(Board board)
        {
            throw new System.NotImplementedException();
        }

        public string Token { get; set; }
    }

    public class ComputerPlayer : IPlayer
    {
        public int GetDesiredMove(Board board)
        {
            throw new System.NotImplementedException();
        }

        public string Token { get; set; }
    }

}

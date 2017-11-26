namespace TicTacToe
{
    public interface IPlayer
    {
        int GetDesiredMove(Board board);
        string Token { get; set; }
    }
}

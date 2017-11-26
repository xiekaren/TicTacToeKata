namespace TicTacToe
{
    public class ComputerPlayer : IPlayer
    {
        public int GetDesiredMove(Board board)
        {
            for (var i = 0; i < board.Length; i++)
            {
                if (board.Cell(i) == "-") return i + 1;
            }
            return -1;
        }

        public string Token { get; set; }
    }
}
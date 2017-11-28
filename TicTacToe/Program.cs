namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new TicTacToe(new Board(), new Display(), new WinChecker(), new ComputerPlayer(), new HumanPlayer());
            game.Play();
        }
    }
}

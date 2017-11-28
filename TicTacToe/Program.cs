using TicTacToe.Checker;
using TicTacToe.GameElements;
using TicTacToe.Interface;
using TicTacToe.Player;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new TicTacToe(new Renderer(), new Board(), new WinChecker(), new ComputerPlayer(), new HumanPlayer(new InputChecker()));
            game.Play();
        }
    }
}

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ticTacToeGame = new Game(new Prompt(new InputValidator()), new Board());
            ticTacToeGame.Start();
        }
    }
}

using System;

namespace alans_n_dragons
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Raptor Alan");
            Player player2 = new Player("Other Raptor Alan");
            GameLogic game = new GameLogic(player1, player2);
            game.GameStart(player1, player2);
        }
    }
}

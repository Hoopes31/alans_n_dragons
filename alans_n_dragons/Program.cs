using System;

namespace alans_n_dragons
{
    class Program
    {
        static void Main(string[] args)
        {
          Deck newDeck = new Deck();
          Player player1 = new Player("Player 1");
          int counter = 1;
          foreach(Card card in newDeck.Cards){
              System.Console.WriteLine(counter);
              card.printCard();
              counter ++;
          }
          player1.Draw(newDeck);
        // player1.ShowHand();
        // player1.Discard(1);
        // player1.Discard(1);
        }
    }
}

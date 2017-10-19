using System;
using System.Linq;

namespace alans_n_dragons
{
    public class GameLogic
    {
        public GameLogic(Player player1, Player player2)
        {
            //GAME START
            //Give Players 30 Health && 1 Turn
            player1.Health = 30;
            player2.Health = 30;
            player1.Turn = 1;
            player2.Turn = 0;

            //Create Player Decks
            player1.playerDeck = new Deck();
            player2.playerDeck = new Deck();

            //Deal each player 5 cards
            StartDeal(player1, 5);
            StartDeal(player2, 5);

            while(player1.Turn > 0 || player2.Turn > 0)
            {

                //Tell Player what cards are in their hand
                //If field is empty => add card to field

                //Else => Would you like to attack or play a card?
                    //If attack => select card in field => select target => attack => end turn
                    //Else allow player to select a card in hand => add to field => end turn
            }
            
            //GAME TURN
            //Card to Field
                //Select Card
                //Select Card Mode
                //Send to Field
                //Reduce Turn
            //Card to action
                //Select Card in Field
                //Select Target (player if available) (or card)
                //Reduce Turn
            
            //Game Finish
                //When Player life = 0
                //Player with life wins
                //Increment Win/Loss Ratio
        }
        public void Welcome()
        {
            System.Console.WriteLine("Welcome to Alans n Dragons.");
            System.Console.WriteLine("Will it be Alan or the Dragon that decide the fate of your match?");
        }
        public void StartDeal(Player player, int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                Draw(player);
            }
        }

        public void Draw(Player player)
        {
            Card card = player.playerDeck.Deal();
            player.Hand.Add(card);
        }

        public void AddToField(Player player1, Player player2, int idx, string decision)
        {
            Card selectedCard = player1.Hand[idx];
            if (decision.ToLower() == "no")
            {
                selectedCard.mode = false;
            }
            player1.Field.Add(selectedCard);
            player1.Turn -= 1;
            player2.Turn += 1;
        }

        //Called before attack to get selected card from field
        public Card CreateAttack(Player player, int idx)
        {
            Card selectedCard = player.Field[idx];
            return selectedCard;
        }

        public void Attack(Player player1, Player player2, object target, Card selectedCard)
        {
            if (selectedCard.mode == true)
            {
                if(target is Card)
                {
                    Card enemy = target as Card;

                    if (enemy.mode == true)
                    {
                        enemy.atk -= selectedCard.atk;
                        selectedCard.atk -= enemy.atk;
                        KillTest(player1, player2, enemy, selectedCard.atk);
                        KillTest(player1, player2, selectedCard, selectedCard.atk);                            
                        player1.Turn -= 1;
                        player2.Turn += 1;
                    }
                    else
                    {
                        enemy.def -= selectedCard.atk;
                        selectedCard.atk -= enemy.def;
                        KillTest(player1, player2, enemy, selectedCard.atk);
                        KillTest(player1, player2, selectedCard, selectedCard.atk);
                        player1.Turn -= 1;
                        player2.Turn += 1;
                    }
                }

                if (target is Player)
                {
                    Player enemy = target as Player;
                    enemy.Health -= selectedCard.atk;
                }
            }
            else
            {
                System.Console.WriteLine($"{selectedCard.name} is a defense card, and cannot attack.");
            }
        }
        public void RemoveFromField(Card card, Player player)
        {
            foreach (Card matchCard in player.Field)
            {
                if (card.Equals(matchCard))
                {
                    player.Field.Remove(matchCard);
                }
            }
        }
        public void KillTest(Player player1, Player player2, object target, int attack)
        {
            if (target is Player)
            {
                Player beingTested = target as Player;
                if (beingTested.Health < 1)
                {
                    //End Game
                    beingTested.Turn = 0;
                    player1.Turn = 0;
                } 
            }
            else
            {
                Card beingTested = target as Card;
                
                if (beingTested.mode == true)
                {
                    beingTested.atk -= attack;
                    if (beingTested.atk < 1)
                    {
                        RemoveFromField(beingTested, player2);
                    }
                }
                else
                {
                    beingTested.def -= attack;
                } 
            }
        }
    }
}
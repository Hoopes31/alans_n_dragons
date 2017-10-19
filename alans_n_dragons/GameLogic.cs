using System;

namespace alans_n_dragons
{
    public class GameLogic
    {
        public GameLogic(Player player1, Player player2)
        {
            //GAME START
            //Give Players 100 Health && 2 Turns
            player1.Health = 100;
            player2.Health = 100;
            player1.Turns = 2;
            player2.Turns = 2;
            
            //Deal player cards

            //Player 1 goes first
                //Player1 plays two turns
                //=> Turn is add to field or || attack
            //Player 2 goes
                //Player2 plays two turns
            
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

            public void Attack(Player player, object target)
            {
                if (player.fieldCard.mode == "atk")
                {
                    if(target is Card)
                    {
                        
                    }
                }
                else
                {
                    System.Console.WriteLine($"{player.fieldCard.name} is a defense card, and cannot attack.");
                }
            }

            public void AddTurns(Player player)
            {
                player.Turns = 2;
            }

        }
    }
}
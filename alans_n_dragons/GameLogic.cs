using System;

namespace alans_n_dragons
{
    public class GameLogic
    {
        public GameLogic(Player player1, Player player2)
        {
            //GAME START
            //Give Players 100 Health && 2 Turns
            player1.Health = 30;
            player2.Health = 30;
            player1.Turns = 2;
            player2.Turns = 2;
            
            //Deal player cards 5
            

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
                if (player.selectedCard.mode == true)
                {
                    if(target is Card)
                    {
                        Card enemy = target as Card;

                        if (enemy.mode == true)
                        {
                            enemy.atk -= player.selectedCard.atk;
                            player.selectedCard.atk -= enemy.atk;
                            KillTest(enemy);
                            player.Turns -= 1;
                        }
                        else
                        {
                            enemy.def -= player.selectedCard.atk;
                            player.Turns -= 1;
                        }
                    }

                    if (target is Player)
                    {
                        Player enemy = target as Player;
                        enemy -= player.selectedCard.atk;
                    }
                }
                else
                {
                    System.Console.WriteLine($"{player.selectedCard.name} is a defense card, and cannot attack.");
                }
            }
            public void KillTest(object target)
            {
                if (target is Player)
                {
                    Player beingTested = beingTested as Player;
                    if (beingTested.health < 1)
                    {
                        //End Game
                    } 
                }
                else (target is Card)
                {
                    Card beingTested = beingTested as Card;
                    if (beingTested.health < 1)
                    {
                        //Remove card from field
                    } 
                }
            }

            public void AddTurns(Player player)
            {
                player.Turns = 2;
            }

        }
    }
}
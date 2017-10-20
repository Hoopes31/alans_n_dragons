using System;
using System.Linq;
using System.Diagnostics;

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

            //Welcome to the Game
            
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
        public void GameStart(Player player1, Player player2)
        {
            
            Welcome(player1, player2);
            Welcome(player2, player1);

            while(player1.Turn > 0 || player2.Turn > 0)
            {
                if(player1.Turn > 0)
                {
                    Logic(player1, player2);
                }
                else
                {
                    Logic(player2, player1);
                }
                //Tell Player what cards are in their hand
                //If field is empty => add card to field

                //Else => Would you like to attack or play a card?
                    //If attack => select card in field => select target => attack => end turn
                    //Else allow player to select a card in hand => add to field => end turn
            }
        }
        public void Welcome(Player player, Player player2)
        {
            System.Console.WriteLine("Welcome to Alans n Dragons.");
            System.Console.WriteLine("Will it be Alan or the Dragon that decide the fate of your match?");
            System.Console.WriteLine("Player enter your name");
            player.Name = System.Console.ReadLine();
            System.Console.WriteLine($"{player.Name} it is your turn. Press any key when ready.");
            var readyCheck = System.Console.ReadLine();
            DisplayCards(player, "hand");
            System.Console.WriteLine("To start select a card to add to the field.");
            System.Console.WriteLine("Cards can be selected by entering their card number.");
            //Set up fail logic for non int numbers.
            string idx = System.Console.ReadLine();
            int idx_number = NumberProtection(idx);
            System.Console.WriteLine("Would you like this card to be an attacking card or defending card?");
            System.Console.WriteLine("For attacking enter 'a'"); 
            System.Console.WriteLine("For defending enter 'd'");
            string decision = System.Console.ReadLine().ToLower();
            AddToField(player, player2, idx_number, decision);
        }
        public void Logic(Player player, Player player2)
        {
            Ascii pictures = new Ascii();
            System.Console.WriteLine($"{player.Name} it is your turn. Press any key when ready.");
            string readyCheck = System.Console.ReadLine();
            DisplayCards(player, "hand");
            System.Console.WriteLine("Would you like to attack or add a card to the field?");
            System.Console.WriteLine("To attack press: A");
            System.Console.WriteLine("To field a card press: F");
            string response = System.Console.ReadLine().ToLower();
            AttackOrField(player, player2, response);
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
        public void DisplayCards(Player player, string handType)
        {
            Ascii pictures = new Ascii();
            if (handType == "hand"){
                System.Console.WriteLine($"{player.Name}'s Hand");

                int count = 0;
                foreach (Card card in player.Hand)
                {
                    System.Console.WriteLine(pictures.cardAscii, card.name, card.atk, card.def, "INACTIVE", count);
                    count ++;
                }
            }
            else
            {
                int count = 0;
                System.Console.WriteLine($"{player.Name}'s Field");
                foreach (Card card in player.Field)
                {
                    string mode = "DEFENDER";
                    if (card.mode == true)
                    {
                        mode = "ATTACKER";
                    }
                    System.Console.WriteLine(pictures.cardAscii, card.name, card.atk, card.def, mode, count);
                    count ++;
                }
                while (count < 4)
                {
                    System.Console.WriteLine(pictures.emptyCard);
                    count ++;
                }
            }
        }
        public void AttackOrField(Player player1, Player player2, string response)
        {
            if (response == "a")
            {
                DisplayCards(player1, "field");
                System.Console.WriteLine("Select a card to attack with.");
                System.Console.WriteLine("Top card is 0 bottom card is 2");
                string idx = System.Console.ReadLine();
                int idx_number = NumberProtection(idx);
                Card attacker = CreateAttack(player1, idx_number);

                //If player2 is defended =>
                if(Defended(player2))
                {
                    System.Console.WriteLine($"{player2.Name} is DEFENDED!");
                    System.Console.WriteLine($"Which of {player2.Name}'s cards would you like to attack?");
                    DisplayCards(player1, "field");
                    string attackResponse = System.Console.ReadLine();
                    int defender = NumberProtection(attackResponse);
                    Card target = CreateAttack(player2, defender);
                    Attack(player1, player2, target, attacker);
                }

                //Else would you like to attack player or players cards?
                else
                {
                    System.Console.WriteLine($"{player2.Name} is open for attack!");
                    System.Console.WriteLine($"Would you like to attack {player2.Name} or their Alans and Dragons?");
                    System.Console.WriteLine($"Press 'a' to attack {player2.Name}");
                    string attackPlayerCheck = System.Console.ReadLine().ToLower();
                    //Player Attack
                    if (attackPlayerCheck == "a")
                    {
                        Attack(player1, player2, player2, attacker);
                    }
                    //Card Attack
                    else
                    {
                        System.Console.WriteLine($"Which of {player2.Name}'s cards would you like to attack?");
                        DisplayCards(player1, "field");
                        string attackResponse = System.Console.ReadLine();
                        int defender = NumberProtection(attackResponse);
                        Card target = CreateAttack(player2, defender);
                        Attack(player1, player2, target, attacker);
                    }

                }
            }
            else
            {
                System.Console.WriteLine("Select a card to field.");
                System.Console.WriteLine("Top card is 0 bottom card is 4");
                string idx = System.Console.ReadLine();
                int idx_number = NumberProtection(idx);

            }
        }
        public void AddToField(Player player1, Player player2, int idx, string decision)
        {
            Card selectedCard = player1.Hand[idx];
            if (decision.ToLower() == "d")
            {
                selectedCard.mode = false;
            }
            player1.Field.Add(selectedCard);
            player1.Turn -= 1;
            player2.Turn += 1;
        }
        public bool Defended(Player player)
        {
            foreach (Card card in player.Field)
            {
                if (card.mode == false)
                {
                    return true;
                }
            }
            return false;
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
                        KillTest(player1, player2, enemy, selectedCard);
                        KillTest(player1, player2, selectedCard, selectedCard.atk);                            
                        player1.Turn -= 1;
                        player2.Turn += 1;
                    }
                    else
                    {
                        enemy.def -= selectedCard.atk;
                        selectedCard.atk -= enemy.def;
                        KillTest(player1, player2, enemy, selectedCard);
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
            Ascii pictures = new Ascii();
            foreach (Card matchCard in player.Field)
            {
                if (card.Equals(matchCard))
                {
                    System.Console.WriteLine(pictures.deadCard, matchCard.name);
                    player.Field.Remove(matchCard);
                    break;
                }
            }
        }
        public int NumberProtection(string value)
        {
            try
            {
                int idx = Int32.Parse(value);
                return idx;
            }
            catch
            {
                System.Console.WriteLine("Value must be a number. Please try again.");
                string retry = System.Console.ReadLine();
                return NumberProtection(retry);
            }
        }
        public void KillTest(Player player1, Player player2, object target, Card attacker)
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
                    beingTested.atk -= attacker.atk;
                    attacker.atk -= beingTested.atk;
                    if (beingTested.atk < 1)
                    {
                        RemoveFromField(beingTested, player2);
                    }
                    if (attacker.atk < 1)
                    {
                        RemoveFromField(attacker, player1);
                    }
                }
                else
                {
                    beingTested.def -= attacker.atk;
                    attacker.atk -= beingTested.def;
                    if (beingTested.def < 1)
                    {
                        RemoveFromField(beingTested, player2);
                    }
                    if (attacker.atk < 1)
                    {
                        RemoveFromField(attacker, player1);
                    }
                } 
            }
        }
    }
}
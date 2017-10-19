using System;
using System.Collections.Generic;

namespace cards 
{
    public class Deck{
        public List<Card> Cards {get;set;}
        public Random rand;

        public Deck(){
            rand = new Random();
            Cards = new List<Card>();
            Reload();
            Shuffle();

        }

        public void Reload(){
            String[] suits = {"Hearts", "Diamonds", "Clubs", "Spades"};
            foreach(string suit in suits){
                for(int i = 1; i < 14; i++){
                    Cards.Add(new Card(suit, i));
                }
            }
        }
        public void Shuffle(){
            Card temp;
            for(int i = 0; i < Cards.Count; i++){
                temp = Cards[i];
                int swap = rand.Next(Cards.Count);
                Cards[i] = Cards[swap];
                Cards[swap] = temp;
            }
        }
        public Card Deal(){
            Card dealt = Cards[0];
            Cards.RemoveAt(0);
            return dealt;
        }
    }
}
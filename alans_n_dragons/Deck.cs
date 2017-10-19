using System;
using System.Collections.Generic;

namespace alans_n_dragons 
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
            String[] types = {"Attack", "Defense"};
            foreach(string type in types){
                for(int i = 0; i < 15; i++){
                    Cards.Add(new Card(type, i));
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
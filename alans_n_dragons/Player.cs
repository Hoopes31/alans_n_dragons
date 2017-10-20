using System;
using System.Collections.Generic;

namespace alans_n_dragons 
{
    public class Player{
        public string Name {get;set;}
        public int Health {get;set;}
        public List<Card> Hand{get;set;}
        public List<Card> Field {get;set;}
        public int Turn {get;set;}
        public Deck playerDeck;

    public Player(string n){
        Name = n;
        Health = 30;
        Hand = new List<Card>();
        Field = new List<Card>(2);
    }

    public void ShowHand(){
        foreach(Card newCard in Hand){
            newCard.printCard();
        }
    }
    public Card Discard(int idx){
        if(idx >= Hand.Count || idx < 0){
            return null;
        }
        Card temp = Hand[idx];
        Hand.RemoveAt(idx);
        return temp;
    }
    }
}
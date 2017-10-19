using System;
using System.Collections.Generic;

namespace cards 
{
    public class Player{
        public string Name {get;set;}
        public List<Card> Hand{get;set;}

    public Player(string n){
        Name = n;
        Hand = new List<Card>();
    }

    public void Draw (Deck newDeck){
        Hand.Add(newDeck.Deal());
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
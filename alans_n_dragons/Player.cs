using System;
using System.Collections.Generic;

namespace alans_n_dragons 
{
    public class Player{
        public string Name {get;set;}
        public int Health {get;set;}
        public List<Card> Hand{get;set;}
        public Card[] Field {get;set;}

    public Player(string n){
        Name = n;
        Health = 30;
        Hand = new List<Card>();
        Field = new Card[3];
    }

    // public Card Draw (Deck newDeck){
    //     Card card = newDeck.Deal();
    //     Hand.Add(card);
    //     return card;
    // }

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
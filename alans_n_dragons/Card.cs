using System;
using System.Collections.Generic;

namespace cards
{
    public class Card{
        public string stringVal {get;set;}
        public int val {get;set;}
        public string suit {get;set;}
        public Card(string s, int v){
            val = v;
            suit = s;
            switch(val)
            {
                case 11:
                    stringVal = "Jack";
                    break;
                case 12:
                    stringVal = "Queen";
                    break;
                case 13:
                    stringVal = "King";
                    break;
                case 1:
                    stringVal = "Ace";
                    break;
                default:
                    stringVal = val.ToString();
                    break;
            }
        }
        public void printCard(){
            System.Console.WriteLine("{0} of {1}", stringVal, suit);
        }
    }
}
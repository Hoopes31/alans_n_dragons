using System;
using System.Collections.Generic;

namespace alans_n_dragons
{
    public class Card{
        public string name {get;set;}
        public int atk {get;set;}
        public int def {get;set;}
        public string type {get;set;}
        public bool mode = true; //true is attack mode
        public Card(string s, int val){           
            type = s;
            if(type == "Attack") {
                if(val < 2) {
                    atk = 1;
                    def = 2;
                    name = "Sleepy Alan";
                }
                else if(val >= 2 && val <  5) {
                    atk = 3;
                    def = 2;
                    name = "Regular Alan";
                }
                else if(val >= 5 && val < 8) {
                    atk = 4;
                    def = 3;
                    name = "Awoken Alan";
                }
                else if(val >= 8 && val < 10){
                    atk = 5;
                    def = 4;
                    name = "Considerate Alan";
                }
                else if(val >= 10 && val > 12){
                    atk = 6;
                    def = 3;
                    name = "Angry Alan";
                }
                else if(val == 12){
                    atk = 7;
                    def = 3;
                    name = "Alan's Attack Dragon";
                }
                else if(val == 13){
                    atk = 8;
                    def = 2;
                    name = "Wyvern";
                }
                else{
                    atk = 9;
                    def = 1;
                    name = "Bahamut";
                }
            }
            else{
                 if(val < 2) {
                    atk = 2;
                    def = 1;
                    name = "Defensive Alan";
                }
                else if(val >= 2 && val <  5) {
                    atk = 2;
                    def = 3;
                    name = "Annoyed Alan";
                }
                else if(val >= 5 && val < 8) {
                    atk = 3;
                    def = 4;
                    name = "Moderately Armored Alan";
                }
                else if(val >= 8 && val < 10){
                    atk = 4;
                    def = 5;
                    name = "Well Armored Alan";
                }
                else if(val >= 10 && val > 12){
                    atk = 3;
                    def = 6;
                    name = "Super Defensive Alan";
                }
                else if(val == 12){
                    atk = 3;
                    def = 7;
                    name = "Alan's Shield Dragon";
                }
                else if(val == 13){
                    atk = 2;
                    def = 8;
                    name = "Snorlax";
                }
                else{
                    atk = 1;
                    def = 9;
                    name = "Wall Dragon";
                }
            }
        }
        public void printCard(){
            System.Console.WriteLine("{0} of {1}", name, type);
        }
    }
}
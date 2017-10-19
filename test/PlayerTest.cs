using System;
using System.Collections.Generic;
using Xunit;
using alans_n_dragons;

namespace test
{
    public class PlayerTest
    {
        Player testPlayer = new Player("Test");
        public void TestProperties()
        {
            Type nameType = testPlayer.Name.GetType();
            Type healthType = testPlayer.Health.GetType();
            Type handType = testPlayer.Hand.GetType();
            int health = testPlayer.Health;
            List<Card> hand = testPlayer.Hand;
            Card[] field = testPlayer.Field;
            Assert.True(nameType.Equals(typeof(string)), "Player name was not a string!");
            Assert.True(healthType.Equals(typeof(int)), "Player health was not an int!");
            Assert.True(handType.Equals(typeof(List<Card>)), "Player hand was not a List!");
            Assert.True(handType.Equals(typeof(Card[])), "Player field was not an array!");
            Assert.True(health.Equals(30), "Player health was not equal to 30!");
            Assert.True(testPlayer.Name.Equals("Test"), "Player name does not equal what was entered");

        }

        // public void TestDraw()
        // {
        //     Deck testDeck = new Deck();
        //     Card card = testPlayer.Draw(testDeck);
        //     Assert.True(testPlayer.Hand[testPlayer.Hand.Count-1].Equals(card), "Card dealt was not card drawn!");
        // }
    }
}
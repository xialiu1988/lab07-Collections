using System;
using System.Collections.Generic;
using System.Linq;

namespace lab7_Collections
{
 public  class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDeck<Card> player1 = new MyDeck<Card>();
            Card card1 = new Card("7", "Dimonds");
            Card card2 = new Card("2", "Hearts");
            Card card3 = new Card("10", "Spades");
            Card card4 = new Card("Q", "Dimonds");
            Card card5 = new Card("Q", "Spades");
            Card card6 = new Card("Ace", "Hearts");
            player1.Add(card1);
            player1.Add(card2);
            player1.Add(card3);
            player1.Add(card4);
            player1.Add(card5);
            player1.Add(card6);

            foreach (Card item in player1)
            {
                Console.WriteLine(item.cardNum + "   " + item.suit);
            }

          



            Console.WriteLine(player1.Count());

        }



    }
}

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

            MyDeck<Card> myDeck = new MyDeck<Card>();
            Card card1 = new Card("7", "Dimonds");
            Card card2 = new Card("2", "Hearts");
            Card card3 = new Card("10", "Spades");
            Card card4 = new Card("Q", "Dimonds");
            Card card5 = new Card("Q", "Spades");
            Card card6 = new Card("Ace", "Hearts");
            myDeck.Add(card1);
            myDeck.Add(card2);
            myDeck.Add(card3);
            myDeck.Add(card4);
            myDeck.Add(card5);
            myDeck.Add(card6);

            Console.WriteLine("The cards in your deck are:");
    
            foreach (Card item in myDeck)
            {
                Console.Write($"{item.cardNum} {item.suit} ");
            }
            Console.WriteLine("      ");
            Console.WriteLine("      ");
            Card[] newarr= myDeck.Remove(card4);
            Console.WriteLine("      ");
            Console.WriteLine($"Cards left:  {myDeck.Count()}");


            //Card[] newdeck = new Card[newarr.Length];
            //Array.Copy(newarr, newdeck, newarr.Length);

            foreach (Card item in newarr)
            {
                if (item == null) return;
               else Console.Write($"{item.cardNum} {item.suit} ");      

            }


            // Deal();

        }

        public void Deal()
        {

        }
    }
}

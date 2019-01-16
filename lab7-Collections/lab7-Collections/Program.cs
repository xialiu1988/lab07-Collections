using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lab7_Collections
{
 public  class Program
    {
        enum Suits { Hearts, Diamonds, Spades, Clubs }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDeck<Card> myDeck = new MyDeck<Card>();
           // Suits type1 = Suits.Diamonds;
            Card card1 = new Card("7",Card.Suits.Diamonds);
            Card card2 = new Card("2", Card.Suits.Hearts);
            Card card3 = new Card("10", Card.Suits.Clubs);
            Card card4 = new Card("Q", Card.Suits.Spades);
            Card card5 = new Card("Q", Card.Suits.Spades);
            Card card6 = new Card("Ace", Card.Suits.Diamonds);
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
            Console.WriteLine("      ");
            foreach (Card item in newarr)
            {
                if(item!=null)
                Console.Write($"{item.cardNum} {item.suit} ");
                
            }

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");

          
                Deal();
            
        }

        public static void Deal()
        {

            MyDeck<Card> palyer1 = new MyDeck<Card>();
            MyDeck<Card> player2 = new MyDeck<Card>();
            MyDeck<Card> dealerDeck = new MyDeck<Card>();
            Console.WriteLine("Player 1  Deck:   Empty ");
            Console.WriteLine("Player 2  Deck:   Empty ");




        }
    }
}

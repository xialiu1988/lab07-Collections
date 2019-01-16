using System;
using System.Collections;
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
            Card card1 = new Card("7",Card.Suits.Diamonds);
            Card card2 = new Card("2", Card.Suits.Hearts);
            Card card3 = new Card("10", Card.Suits.Clubs);
            Card card4 = new Card("K", Card.Suits.Spades);
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
            //reomove one card from deck
            Card[] newarr= myDeck.Remove(card4);
            Console.WriteLine($"Removing {card4.cardNum} {card4.suit}");

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
            Console.WriteLine(" Would you like to start game?y/n ");
            string input = Console.ReadLine();
            string input2 = input.ToLower();
            if (input2 == "y")
            {
                Console.WriteLine("  ");
                Deal();
            }
            else Environment.Exit(0);
            
        }

        public static void Deal()
        {

            MyDeck<Card> player1 = new MyDeck<Card>();
            MyDeck<Card> player2 = new MyDeck<Card>();
            MyDeck<Card> dealerDeck = new MyDeck<Card>();


            Card card1 = new Card("Ace", Card.Suits.Diamonds);
            Card card2 = new Card("K", Card.Suits.Hearts);
            Card card3 = new Card("Q", Card.Suits.Clubs);
            Card card4 = new Card("10", Card.Suits.Spades);
            Card card5 = new Card("6", Card.Suits.Spades);

            dealerDeck.Add(card1);
            dealerDeck.Add(card2);
            dealerDeck.Add(card3);
            dealerDeck.Add(card4);
            dealerDeck.Add(card5);


            Console.WriteLine("Player 1  Deck:   Empty ");
            Console.WriteLine("Player 2  Deck:   Empty ");
            Console.Write("Dealer Deck: ");
            foreach (Card item in dealerDeck)
            {
                Console.Write($"{item.cardNum} {item.suit} ");
            }
            Console.WriteLine("          ");
            Console.WriteLine("          ");
            Console.WriteLine("(Distributing Deck)");
            Console.WriteLine("          ");
            Console.WriteLine("          ");

            player1.Add(card1);
            player1.Add(card2);
            player2.Add(card5);
            player2.Add(card4);
            dealerDeck.Remove(card1);
            dealerDeck.Remove(card2);
            dealerDeck.Remove(card5);
            dealerDeck.Remove(card4);

            Console.Write("Player 1 Deck: ");
            foreach (Card item in player1)
            {
                Console.Write($"{item.cardNum} {item.suit} ");
            }
            Console.WriteLine("          ");

            Console.Write("Player 2 Deck: ");
            foreach (Card item in player2)
            {
                Console.Write($"{item.cardNum} {item.suit} ");
            }
            Console.WriteLine("          ");
            Console.Write(" Dealer Deck: ");
            foreach (Card item in dealerDeck)
            {
                if (item != null)
                    Console.Write($"{item.cardNum} {item.suit} ");
            }

            Console.WriteLine("          ");
            Console.WriteLine("          ");

        }
    }
}

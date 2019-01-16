using System;
using System.Collections.Generic;
using System.Text;

namespace lab7_Collections
{ 


    public class Card
    {
     public enum Suits { Hearts, Diamonds, Spades, Clubs }
        public string cardNum { get; set; }
        public Suits suit { get; set;}

       
        public Card(string cardN,Suits suitName)
        {
           
            cardNum=cardN;
            suit = suitName;
        }
    }
}
